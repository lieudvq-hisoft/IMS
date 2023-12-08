using static Data.Utils.Tree.TreeExtensions;

namespace Data.Utils.Tree;
public static class TreeExtension
{
    public static IEnumerable<ITree<T>> GetAllChildren<T>(this ITree<T> tree)
    {
        return tree.Children.Flatten(x => x.Children);
    }
}
