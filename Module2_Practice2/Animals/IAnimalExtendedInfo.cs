namespace Module2_Practice2.Animals
{
    // a contract to force final classes to implement
    // additional information about a particular animal
    public interface IAnimalExtendedInfo
    {
        ConservationStatus ConservationStatus { get; init; }
        AnimalOrder AnimalOrder { get; init; }

        string ConservationStatusInfo { get; }
        string AnimalOrderInfo { get; }
    }
}
