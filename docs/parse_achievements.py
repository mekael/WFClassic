import csv
import json
jsn = []

with open("./achievements.md") as csv_file:
    rows = csv.reader(csv_file, delimiter="|")
    for row in rows:
        jsn.append( {
            "Name" : row[2],
            "Description" : row[3]
        })

print(json.dumps(jsn, indent=5))


