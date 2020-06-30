namespace WorldAPI.DAL.Contracts
{
	public interface IRepositoryWrapper
	{
		ICityRepository City { get; }
		IStateRepository State { get; }
		ICountryRepository Country { get; }
		void Save();

	}
}
