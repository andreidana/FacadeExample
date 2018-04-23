namespace FacadeExample
{
    public class HouseBuilderFacade
    {
        private readonly ElectricityCables _electricityCables;
        private readonly GasPipes _gasPipes;
        private readonly WaterPipes _waterPipes;
        private readonly PoolInstallation _poolInstallation;

        public HouseBuilderFacade()
        {
            _electricityCables = new ElectricityCables();
            _gasPipes = new GasPipes();
            _waterPipes = new WaterPipes();
            _poolInstallation = new PoolInstallation();
        }

        public void BuildHouse()
        {
            _waterPipes.ConnectPipes();
            _gasPipes.ConnectGasPipes();
            _electricityCables.ConnectElectricityCables();
        }

        public void BuildMansion()
        {
            _waterPipes.ConnectPipes();
            _gasPipes.ConnectGasPipes();
            _electricityCables.ConnectElectricityCables();
            _poolInstallation.InstallPool();
        }
    }
}