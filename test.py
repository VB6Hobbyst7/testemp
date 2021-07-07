from django.db import connection

cursor =connection.cursor()
cursor.execute("CALL newUserGroupEmp('EMP-5', 'Greg', 'Jones', 'gregjones@yahoo.com',"
               "DATE '1969-09-12', 1, 1, 'EN', 1, 'testing321', 0")
data = cursor.fetchone()

print(data)
