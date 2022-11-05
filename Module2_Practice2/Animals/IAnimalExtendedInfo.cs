namespace Module2_Practice2.Animals
{
    // a contract to force finial classes to implement additional information
    public interface IAnimalExtendedInfo
    {
        ConservationStatus ConservationStatus { get; init; }
        AnimalOrder AnimalOrder { get; init; }

        string ConservationStatusInfo { get; }
        string AnimalOrderInfo { get; }
    }
}
