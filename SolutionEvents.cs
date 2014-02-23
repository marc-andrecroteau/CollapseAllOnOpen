using EnvDTE;
using EnvDTE80;

namespace Crotz.CollapseAllOnOpen
{
    public class SolutionEvents
    {
        #region Fields

        private readonly DTE2 _applicationObject;
        private DocumentEvents _documentEvents;
        private WindowEvents _windowsEvents;
        private bool _docOpened;

        #endregion

        #region Constructor

        public SolutionEvents(DTE2 applicationObject)
        {
            _applicationObject = applicationObject;

            _documentEvents = _applicationObject.Events.DocumentEvents;
            _windowsEvents = _applicationObject.Events.WindowEvents;

            _documentEvents.DocumentOpened += DocumentEvents_DocumentOpened;
            _windowsEvents.WindowActivated += WindowEvents_WindowActivated;
        }

        #endregion

        #region Events

        private void WindowEvents_WindowActivated(Window gotFocus, Window lostFocus)
        {
            if (gotFocus.Document == null)
            {
                return;
            }

            if (gotFocus.Document.FullName.EndsWith(".cs") & _docOpened)
            {
                _applicationObject.ExecuteCommand("Edit.CollapsetoDefinitions");
            }

            _docOpened = false;
        }

        private void DocumentEvents_DocumentOpened(Document document)
        {
            _docOpened = true;
        }

        #endregion
    }
}