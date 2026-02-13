using System;
using System.Collections.Generic;
using System.Text;

namespace MetronomeApp.Global;

public class Config
{

    public static string binPath = @AppContext.BaseDirectory;
    public static string projectRoot = @Directory.GetParent(binPath)!.Parent!.Parent!.Parent!.FullName;
    public static string AppName = "MetronomeApp";

    public static string MetronomeSoundsFolderName = "MetronomeSounds";
    public static string MetronomeSoundsPath = @Path.Combine(projectRoot, MetronomeSoundsFolderName);



}
