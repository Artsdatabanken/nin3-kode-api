using System.ComponentModel.DataAnnotations;

namespace NiN3KodeAPI.Entities.Enums
{
    public enum MaalestokkEnum
    {
        [Display(Name = "grunntype")]
        G,
        [Display(Name = "kartleggingsenhet tilpasset 1:5000")]
	    M005K,
        [Display(Name = "kartleggingsenhet tilpasset 1:10 000")]
	    M010K,
        [Display(Name = "kartleggingsenhet tilpasset 1:20 000")]
	    M020K,
        [Display(Name = "kartleggingsenhet tilpasset 1:50 000")]
	    M050K,
        [Display(Name = "kartleggingsenhet tilpasset 1:100 000")]
	    M100K
    }
}
