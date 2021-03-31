using Myra.Graphics2D.UI;
using System;

namespace Myra.Utility
{
    public static class UIUtils
    {
        public static bool ProcessWidgets(this Widget root, Func<Widget, object, bool> operation)
            => root.ProcessWidgets(operation, null);

        public static bool ProcessWidgets<TContext>(this Widget root, Func<Widget, TContext, bool> operation, TContext context)
        {
            if (!root.Visible)
            {
                return true;
            }

            var result = operation(root, context);
            if (!result)
            {
                return false;
            }

            var asContainer = root as Container;
            if (asContainer != null)
            {
                foreach (var w in asContainer.ChildrenCopy)
                {
                    if (!ProcessWidgets(w, operation, context))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
