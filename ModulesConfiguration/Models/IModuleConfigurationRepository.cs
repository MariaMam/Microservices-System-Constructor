using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuleConfiguration.Models
{
  public interface IModuleConfigurationRepository
  {
    void Add(TblModuleControlConfig item);
    TblModuleControlConfig FindByID(Guid key);
    TblModuleControlConfig Remove(Guid key);
    void Update(TblModuleControlConfig item);
    List<TblModuleControlConfig> GetforModule(string module);
    List<TblModuleControlConfig> Get();
    List<TblModuleControlConfigSetting> GetModuleSettings(string module);

  }
}
