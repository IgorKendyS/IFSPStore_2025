using IFSPStore.Repository.Context;
using System.Diagnostics;

namespace IFSPStore.Test
{
    [TestClass]
    public sealed class RepositoryTest
    {
        [TestMethod]
        public void TestCategory()
        {
            using (var context = new IFSPStoreContext())
            {
                Debug.WriteLine("Connected!");
            }
        }
    }
}
