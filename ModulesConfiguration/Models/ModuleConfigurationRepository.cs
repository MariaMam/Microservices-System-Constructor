using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModuleConfiguration.Models;

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

    public List<TblModuleControlConfig> Get()    {
       
        return _context.TblModuleControlConfig.OrderByDescending(u => u.DisplayOrder).Take(20).ToList();
    }

    public List<TblModuleControlConfig> GetforModule(string module)
    {
      Guid moduleId= _context.TblEmexModule.Where(b => b.Name == module)
                    .FirstOrDefault().ModuleId;

      Guid moduleConfigId = _context.TblModuleConfig.Where(b => b.ModuleId == moduleId)
                    .FirstOrDefault().ModuleConfigId;

      List<Guid> moduleConfigGroupsId = _context.TblModuleGroupConfig.Where(b => b.ModuleConfigId == moduleConfigId).Select(b=>b.ModuleGroupConfigId).ToList();

      List<TblModuleControlConfig> controls = (_context.TblModuleControlConfig.Where(b => moduleConfigGroupsId.Contains(b.ModuleGroupConfigId))).ToList();

      return controls;
    }

    public List<TblModuleControlConfigSetting> GetModuleSettings(string module)
    {
      Guid moduleId = _context.TblEmexModule.Where(b => b.Name == module)
                    .FirstOrDefault().ModuleId;

      List<TblModuleControlConfigSetting> controls = (_context.TblModuleControlConfigSetting.Where(b=>b.ModuleId==moduleId).ToList());

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
    //TODO - rework to Asynchronic
    /*
    public async Task<IActionResult> Update(Guid id, [Bind("ID,EnrollmentDate,FirstMidName,LastName")] TblEquipmentItem item)
    {

    }*/
  }
}
