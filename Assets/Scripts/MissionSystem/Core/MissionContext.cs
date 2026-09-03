using System.Collections.Generic;

public class MissionContext
{
    private Dictionary<string, object> variables = new Dictionary<string, object>();
    private HashSet<MissionFlagSO> flags = new HashSet<MissionFlagSO>();
    public void SetValue(string key, object value)
        { 
          variables[key] = value; 
        }

    public T GetValue<T>(string key)
    {
       if (variables.TryGetValue(key, out object value))
        {  
          return (T)value; 
        }
       return default;
    }    

    public bool HasKey(string key)
        { 
          return variables.ContainsKey(key); 
        }
    public void SetFlag(MissionFlagSO flag)
    { 
     flags.Add(flag);
    }

    public bool HasFlag(MissionFlagSO flag)
    { 
     return flags.Contains(flag);
    }

    public void ClearFlag(MissionFlagSO flag)
    { 
     flags.Remove(flag);
    }

}
