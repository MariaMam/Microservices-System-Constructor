using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModuleConfiguration.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ModuleConfiguration.Models
{
  public class ModuleConfigurationRepository : IModuleConfigurationRepository
  {
    private static ConcurrentDictionary<string, TblModuleControlConfig> _controlConfigs =
          new ConcurrentDictionary<string, TblModuleControlConfig>();
    private readonly ModuleConfigurationContext _context;

    public ModuleConfigurationRepository(ModuleConfigurationContext context)
    {
      _context = context;

    }

    public List<TblModuleControlConfig> Get() {

      return _context.TblModuleControlConfig.OrderByDescending(u => u.DisplayOrder).Take(20).ToList();
    }

    public List<TblModuleControlConfig> GetforModule(string module)
    {
      Guid moduleId = _context.TblEmexModule.Where(b => b.Name == module)
                    .FirstOrDefault().ModuleId;

      Guid moduleConfigId = _context.TblModuleConfig.Where(b => b.ModuleId == moduleId)
                    .FirstOrDefault().ModuleConfigId;

      List<Guid> moduleConfigGroupsId = _context.TblModuleGroupConfig.Where(b => b.ModuleConfigId == moduleConfigId).Select(b => b.ModuleGroupConfigId).ToList();

      List<TblModuleControlConfig> controls = (_context.TblModuleControlConfig.Where(b => moduleConfigGroupsId.Contains(b.ModuleGroupConfigId))).ToList();

      return controls;
    }

    public List<TblModuleControlConfigSetting> GetModuleSettings(string module)
    {
      Guid moduleId = _context.TblEmexModule.Where(b => b.Name == module)
                    .FirstOrDefault().ModuleId;

      List<TblModuleControlConfigSetting> controls = (_context.TblModuleControlConfigSetting.Where(b => b.ModuleId == moduleId).ToList());

      return controls;
    }

    public void Add(TblModuleControlConfig config)
    {
      config.ModuleControlConfigId = Guid.NewGuid();
      _controlConfigs[config.ModuleControlConfigId.ToString()] = config;
    }

    public TblModuleControlConfig FindByID(Guid id)
    {
      TblModuleControlConfig config = _context.TblModuleControlConfig.Find(id);
      return config;
    }

    public TblModuleControlConfig Remove(Guid id)
    {
      TblModuleControlConfig item = _context.TblModuleControlConfig.Find(id);
      _context.Remove(item);
      return item;
    }

    public void Update(TblModuleControlConfig config)
    {


    }

    public void UpdateModuleSettings(JArray configs, string module)
    {

      Guid moduleId = _context.TblEmexModule.Where(b => b.Name == module)
              .FirstOrDefault().ModuleId;
      var mc = this.getControlsByModule(module);
      try
      {
        List<TblModuleControlConfigSetting> updateSettingsList = new List<TblModuleControlConfigSetting>();

        foreach (var obj in configs)
        {
          var el = obj["data"];

          TblModuleControlConfigSetting cnf = JsonConvert.DeserializeObject<TblModuleControlConfigSetting>(el.ToString());
          _context.TblModuleControlConfigSetting.Update(cnf);

          if (cnf.IsConfigured && cnf.ModuleControlConfigId == null)
          {

            TblModuleControlConfig newConfig = getNewControl();
            newConfig.DataType = cnf.DataType;
            newConfig.ColumnName = cnf.ColumnName;
            newConfig.ModuleControlConfigId = Guid.NewGuid();
            newConfig.ModuleGroupConfigId = new Guid("CC24E4A9-CFF1-4FC0-8525-4CBAAB48C4F1");

            cnf.ModuleControlConfigId = newConfig.ModuleControlConfigId;
            _context.TblModuleControlConfig.AddAsync(newConfig);
            _context.Update(cnf);

          }

          else if (!cnf.IsConfigured && cnf.ModuleControlConfigId != null)
          {
            var o = _context.TblModuleControlConfig.FirstOrDefault(a => a.ModuleControlConfigId == ((Guid)cnf.ModuleControlConfigId));
            cnf.ModuleControlConfigId = null;
            cnf.IsConfigured = false;
            _context.TblModuleControlConfig.Remove(o);
            _context.Update(cnf);

          }
          

        }
        _context.SaveChangesAsync();
        
      }
      catch (Exception ex) {

        Console.WriteLine(ex.Message);
        
      }
    }




    public List<TblModuleControlConfig> getControlsByModule(string module)
    {
      Guid moduleId = _context.TblEmexModule.Where(b => b.Name == module)
                    .FirstOrDefault().ModuleId;

      Guid moduleConfigId = _context.TblModuleConfig.Where(b => b.ModuleId == moduleId)
                    .FirstOrDefault().ModuleConfigId;

      List<Guid> moduleConfigGroupsId = _context.TblModuleGroupConfig.Where(b => b.ModuleConfigId == moduleConfigId).Select(b => b.ModuleGroupConfigId).ToList();

      List<TblModuleControlConfig> controls = (_context.TblModuleControlConfig.Where(b => moduleConfigGroupsId.Contains(b.ModuleGroupConfigId))).ToList();

      return controls;
    }

    public TblModuleControlConfig getNewControl()
    {
      TblModuleControlConfig control = new TblModuleControlConfig();

      control.ColumnName = "";
      control.DataType = 0;
      control.DisplayOrder = 0;
      control.Ignore = false;
      control.IsCustomControl = false;
      control.IsCustomField = false;
      control.IsDisabled = false;
      control.IsReadonly = false;
      control.IsRequired = false;
      control.ModuleSectionConfigId = null;
      return control;
    }

   
    //TODO - rework to Asynchronic
    /*
    public async Task<IActionResult> Update(Guid id, [Bind("ID,EnrollmentDate,FirstMidName,LastName")] TblEquipmentItem item)
    {

    }*/
  }
}
