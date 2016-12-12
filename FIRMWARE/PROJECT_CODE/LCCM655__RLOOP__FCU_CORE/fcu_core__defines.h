/**
 * @file		FCU_CORE__DEFINES.H
 * @brief		Flight control code constatants
 * @author		Lachlan Grogan
 * @copyright	rLoop Inc.
 */
#ifndef RLOOP_LCCM655__RLOOP__FCU_CORE_FCU_CORE__DEFINES_H_
#define RLOOP_LCCM655__RLOOP__FCU_CORE_FCU_CORE__DEFINES_H_


	/** the number of brake actuators in the system */
	#define C_FCU__NUM_BRAKES								(2U)


	/** 2 Accel devices on the PCB - DO NOT CHANGE */
	#define C_FCU__NUM_ACCEL_CHIPS							(2U)

	/** Hover Engines */
	#define C_FCU__NUM_HOVER_ENGINES						(8U)

	//laser orientation code defines
	#define LASER_ORIENT__X 0U
	#define LASER_ORIENT__Y 1U
	#define LASER_ORIENT__Z 2U
	#define LASER_ORIENT__A 0U
	#define LASER_ORIENT__B 1U
	#define LASER_ORIENT__C 2U
	#define LASER_ORIENT__D 3U

	/** Number of lasers facing down to the ground */
	#define C_FCU__NUM_LASERS_GROUND						(4U)

	/** number of lasers for the i-beam */
	#define C_FCU__NUM_LASERS_IBEAM							(2U)



#endif /* RLOOP_LCCM655__RLOOP__FCU_CORE_FCU_CORE__DEFINES_H_ */
