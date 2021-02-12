using RimWorld;
using Verse;

namespace PetThemAll
{
    [DefOf]
    public class PetThemAllDefOf
    {
        // go pet
        public static JoyGiverDef PetThemAll_Pettings_JoyGiver;
        public static JobDef PetThemAll_Pettings_Job;

        // play fetch
        //public static JoyGiverDef Revolus_AnimalsAreFun_Fetch_JoyGiver;
       // public static JobDef Revolus_AnimalsAreFun_Fetch_Job;
        //public static JobDef Revolus_AnimalsAreFun_Walkies_Job_Animal;

        static PetThemAllDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(PetThemAllDefOf));
        }
    }
}
