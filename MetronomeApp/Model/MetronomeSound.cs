using System;
using System.Collections.Generic;
using System.Text;

namespace MetronomeApp.Model;

public class MetronomeSound
{
    public string path { get; set; } = string.Empty;
    public string name { get; set; } = string.Empty;

    public override string ToString()
    {
        return name;
    }
}
