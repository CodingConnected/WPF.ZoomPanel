using System.Windows;
using System.Windows.Media;

namespace CodingConnected.ZoomPanel.Helpers
{
    public static class VisualTreeHelpers
    {
        #region Public Methods

        /// <summary>
        /// Find first child of type T in VisualTree.
        /// </summary>
        public static T FindChildControl<T>(this DependencyObject control) where T : DependencyObject
        {
            int childNumber = VisualTreeHelper.GetChildrenCount(control);
            if (childNumber > 0)
            {
                DependencyObject child = VisualTreeHelper.GetChild(control, 0);
                return child is T t
                    ? t
                    : child.FindChildControl<T>();
            }
            return null;
        }

        /// <summary>
        /// Find first paretn of type T in VisualTree.
        /// </summary>
        public static T FindParentControl<T>(this DependencyObject control) where T : DependencyObject
        {
            DependencyObject parent = VisualTreeHelper.GetParent(control);
            while (parent != null && parent is not T)
            {
                parent = VisualTreeHelper.GetParent(parent);
            }

            return parent as T;
        }

        #endregion Public Methods
    }
}
