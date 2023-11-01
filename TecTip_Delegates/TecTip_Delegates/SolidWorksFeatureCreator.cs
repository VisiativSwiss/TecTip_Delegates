using static TecTip_Delegates.Delegate;

namespace TecTip_Delegates
{
    public class SolidWorksFeatureCreator
    {
        // Ereignis basierend auf dem obigen Delegaten
        public event FeatureCreatedEventHandler FeatureCreated;

        // Diese Methode löst das FeatureCreated-Ereignis aus
        protected virtual void OnFeatureCreated(string featureName)
        {
            // Überprüfen, ob es Abonnenten gibt
            FeatureCreated?.Invoke(featureName);
        }

        // Stellen Sie sich diese Methode als die, die ein Feature in SolidWorks erstellt
        public void CreateFeature(string featureName)
        {
            // Hier würde Code stehen, der das Feature tatsächlich erstellt
            // ...

            // Nachdem das Feature erstellt wurde, lösen wir das Ereignis aus
            OnFeatureCreated(featureName);
        }
    }

}
