using AElf.Consensus.AElfConsensus;
using AElf.Kernel;
using AElf.Sdk.CSharp.State;
using Google.Protobuf.WellKnownTypes;

namespace AElf.Contracts.Consensus.AElfConsensus
{
    public partial class AElfConsensusContractState : ContractState
    {
        public BoolState Initialized { get; set; }

        public SingletonState<int> TimeEachTerm { get; set; }

        public SingletonState<long> CurrentRoundNumber { get; set; }

        public SingletonState<long> CurrentTermNumber { get; set; }

        public SingletonState<Timestamp> BlockchainStartTimestamp { get; set; }

        public MappedState<long, Round> Rounds { get; set; }
        
        public SingletonState<int> MiningInterval { get; set; }

        public MappedState<long, long> FirstRoundNumberOfEachTerm { get; set; }

        public MappedState<long, Miners> MinersMap { get; set; }
        
        public SingletonState<int> BaseTimeUnit { get; set; }
    }
}