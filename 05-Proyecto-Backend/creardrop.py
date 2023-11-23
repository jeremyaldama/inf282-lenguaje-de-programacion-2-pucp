# Open the input file with the create procedure clauses
with open("script-drop-create-procedures.sql", "r") as input_file:
    # Open the output file to write the drop procedure statements
    with open("drop_procedures.txt", "w") as output_file:
        # Loop through each line in the input file
        drops = []
        for line in input_file:
            # Check if the line starts with "create procedure"
            if line.lower().startswith("create procedure"):
                # Split the line by spaces and get the second element, which is the procedure name
                procedure_name = line.split()[2].split("(")[0]
                # Format the drop procedure statement with the procedure name
                drop_statement = f"drop procedure if exists {procedure_name};\n"
                drops.append(drop_statement)
        drops.sort()        
        for drop_statement in drops:
            output_file.write(drop_statement)
