import java.text.SimpleDateFormat;
import java.util.ArrayList;
/*
	Elaborado por: FREDDY PAZ
	Fecha: 22-08-23
*/
class Principal{
	public static void main(String[] args) throws Exception{
		//Inicializamos una variable para manejar fechas
		SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
		
		//Inicializamos un EQuipu
		EQuipu objEquipu = new EQuipu();

		//Inicializamos un equipo
		Equipo objEquipo1 = new Equipo("HCI-DUXAIT","Temas de Interacción Humano-Computador");

		//Esta sería otra alternativa a utilizar el constructo
		//objEquipo1.setNombre("HCI-DUXAIT");
		//objEquipo1.setInteres("Temas de Interaccion Humano-Computador");
		
		//Inicializamos a los miembros de un equipo
		Estudiante objEstudiante1 = new Estudiante("20090606", "Juan", "Perez", sdf.parse("20-03-1992"), "Av. Universitaria 2021 - San Miguel", "jperez@pucp.edu.pe", 'M', 68.3);
		Profesor objProfesor1 = new Profesor("46891", "Andrea", "Montenegro", sdf.parse("30-10-1965"), "Av. Bolivar 872 - Pueblo Libre", "amontenegro@pucp.edu.pe", 'F',Dedicacion.TC);
		Estudiante objEstudiante2 = new Estudiante("20096969", "Viviana", "Rivasplata", sdf.parse("01-01-1995"), "Av. La Marina 2873 - San Miguel", "vivirivasplata@pucp.edu.pe", 'F', 64.5);
		MiembroExterno objMExterno1 = new MiembroExterno("Jorge", "Santisteban", sdf.parse("04-07-1982"), "Av. Brasil 1023 - Jesus Maria", "jsantiste@gmail.com", 'M', 'T');
		
		//Inicializamos la lista de miembros dentro del equipo
		objEquipo1.setMiembros(new ArrayList<Miembro>());
		
		//Agregamos los miembros al equipo
		objEquipo1.getMiembros().add(objEstudiante1);
		objEquipo1.getMiembros().add(objProfesor1);
		objEquipo1.getMiembros().add(objEstudiante2);
		objEquipo1.getMiembros().add(objMExterno1);

		//Inicializamos la lista de equipos dentro del EQuipu
		objEquipu.setEquipos(new ArrayList<Equipo>());
		
		//Agregamos los equipos al EQuipu
		objEquipu.getEquipos().add(objEquipo1);
		
		String reporte = objEquipu.consultarMiembrosEquipo(0);
		
		//Nótese que a pesar de que el equipo con índice 0 dentro de EQuipu tiene 4 integrantes solo aparecen 3 (aquellos que son únicamente de tipo Miembros PUCP) 
		System.out.print(reporte);
	}
}