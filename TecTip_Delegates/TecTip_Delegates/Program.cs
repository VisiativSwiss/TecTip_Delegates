namespace TecTip_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var creator = new SolidWorksFeatureCreator();
            var subscriber = new FeatureCreationSubscriber();

            // Abonnieren des Ereignisses
            subscriber.Subscribe(creator);

            // Erstellen eines Features, was das Ereignis auslösen sollte
            creator.CreateFeature("Bolzen");
        }
    }

}
