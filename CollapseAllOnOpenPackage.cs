using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.Shell;

namespace Crotz.CollapseAllOnOpen
{
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    [Guid(GuidList.guidCollapseAllOnOpenPkgString)]
    [ProvideAutoLoad(UIContextGuids80.SolutionExists)]
    public sealed class CollapseAllOnOpenPackage : Package
    {
        #region Constructor

        public CollapseAllOnOpenPackage()
        {
            Debug.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering constructor for: {0}", this.ToString()));
        }

        #endregion


        #region Package Members

        private SolutionEvents _solutionEvents;

        protected override void Initialize()
        {
            Debug.WriteLine (string.Format(CultureInfo.CurrentCulture, "Entering Initialize() of: {0}", this.ToString()));

            _solutionEvents = new SolutionEvents((DTE2)GetService(typeof(DTE)));

            base.Initialize();
        }

        #endregion
    }
}
