using System.IO;
using Cysharp.Threading.Tasks;
using Nomnom.UnityProjectPatcher.Editor;
using Nomnom.UnityProjectPatcher.Editor.Steps;
using UnityEditor;

namespace Badhamknibbs.NeonWhiteProjectPatcher.Editor {
    [UPPatcher("com.badhamknibbs.unity-neonwhite-project-patcher")]
    public static class NeonWhiteWrapper {
        public static void GetSteps(StepPipeline stepPipeline) {
            stepPipeline.SetInputSystem(InputSystemType.InputSystem_New);
            stepPipeline.SetGameViewResolution("16:9");
            stepPipeline.OpenSceneAtEnd("InitSceneLaunchOptions");
        }
    }
}