/**
 * @file		FCU__LASER_OPTO__FILTERING.C
 * @brief		OptoNCDT laser filtering system
 * @author		Lachlan Grogan
 * @copyright	rLoop Inc.
 */
/**
 * @addtogroup RLOOP
 * @{ */
/**
 * @addtogroup FCU
 * @ingroup RLOOP
 * @{ */
/**
 * @addtogroup FCU__LASER_OPTO__FILTERING
 * @ingroup FCU
 * @{ */

#include "../fcu_core.h"

#if C_LOCALDEF__LCCM655__ENABLE_THIS_MODULE == 1U
#if C_LOCALDEF__LCCM655__ENABLE_LASER_OPTONCDT == 1U

//the structure
extern struct _strFCU sFCU;

void vFCU_LASEROPTO_FILT__FilterPacket(E_FCU__LASER_OPTO__INDEX_T eLaser)
{

	//new data source here:
	//sFCU.sLaserOpto.sOptoLaser[(Luint8)eLaser].f32Distance


	//todo: filter


	//update this value:
	//sFCU.sLaserOpto.sOptoLaser[u8Counter].sFiltered.f32FilteredValue


}


#endif //C_LOCALDEF__LCCM655__ENABLE_LASER_OPTONCDT

#endif //#if C_LOCALDEF__LCCM655__ENABLE_THIS_MODULE == 1U
//safetys
#ifndef C_LOCALDEF__LCCM655__ENABLE_THIS_MODULE
	#error
#endif
/** @} */
/** @} */
/** @} */
