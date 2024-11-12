using System.Activities;
using System.Xml.Linq;
using infrastracturVerisoft.Interface;

namespace infrastracturVerisoft
{
    public class FrameworkManager
    {
        private static FrameworkManager? instance;
        private List<IBeforeAll> beforeAlls;
        private List<IBeforeEach> beforeEaches;
        private List<IAfterAll> afterAlls;
        private List<IAfterEach> afterEachs;
        private FrameworkManager() {
            beforeEaches = new List<IBeforeEach>();
            beforeAlls =new List<IBeforeAll>();
            afterAlls = new List<IAfterAll>();
            afterEachs = new List<IAfterEach>();    
        }
        public static FrameworkManager GetInstance() {
            if (instance == null) { 
            instance = new FrameworkManager();
            }
            return instance;
        
        }

        public  void AddBeforeAll(IBeforeAll beforeAll)
        {
            beforeAlls.Add(beforeAll);
        }

        public void AddBeforeEach(IBeforeEach beforeEach)
        {
            beforeEaches.Add(beforeEach);
        }

       public void AddAfterAll(IAfterAll afterAll)
        {
            afterAlls.Add(afterAll);
        }

        public void AddAfterEach(IAfterEach afterEach)
        {
            afterEachs.Add(afterEach);
        }
        public  void ExacuteBeforeAll(IBeforeAll beforeAll)
        {
               foreach (IBeforeAll before in beforeAlls)
            {
                beforeAll.BeforeAll();
            }
        }

        public void ExacuteBeforEach(IBeforeEach beforeEach)
        {
            foreach(IBeforeEach before in beforeEaches)
            {
                before.BeforeEach();
            }
        }

        public void ExacuteAfterEach(IAfterEach AfterEach)
        {
            foreach (IAfterEach after in afterEachs)
            {
                after.AfterEach();
            }
        }

        public void ExacuteAfterAll(IAfterAll AfterAll)
        {
            foreach (IAfterAll after in afterAlls)
            {
                after.AfterAll();
            }
        }

    }
}
