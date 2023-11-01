using System;

namespace TecTip_Delegates
{
    public class FeatureCreationSubscriber
    {
        public void Subscribe(SolidWorksFeatureCreator creator)
        {
            // Abonnieren des Ereignisses
            creator.FeatureCreated += OnFeatureCreated;
        }

        // Diese Methode wird aufgerufen, wenn das Ereignis ausgelöst wird
        private void OnFeatureCreated(string featureName)
        {
            Console.WriteLine($"Ein neues Feature wurde erstellt: {featureName}");
        }
    }

}
