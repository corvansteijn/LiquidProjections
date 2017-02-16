using System.Threading.Tasks;

namespace LiquidProjections
{
    public interface IProjector<in TProjectionContext>
    {
        /// <summary>
        /// Asynchronously projects event <paramref name="anEvent"/> using context <paramref name="context"/>.
        /// </summary>
        Task ProjectEvent(object anEvent, TProjectionContext context);
    }
}