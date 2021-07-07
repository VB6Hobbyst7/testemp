from rest_framework import serializers


class DesignationSerializer(serializers.Serializer):
    designation_code = serializers.CharField(max_length=3)
    name = serializers.CharField(max_length=20)
    description = serializers.CharField()
    

class EmployeeAddressSerializer(serializers.Serializer):
    address_line_1 = serializers.CharField(max_length=50)
    address_line_2 = serializers.CharField(max_length=50)
    city = serializers.CharField(max_length=50)
    state = serializers.CharField(max_length=2)
    zip_code = serializers.IntegerField()


class EmployeeSerializer(serializers.Serializer):
    employee_code = serializers.CharField(max_length=20)
    first_name = serializers.CharField(max_length=20)
    last_name = serializers.CharField(max_length=20)
    email = serializers.EmailField()
    date_of_birth = serializers.DateField()
    is_active = serializers.BooleanField()
    designation = DesignationSerializer()
    user = serializers.StringRelatedField()
    employee_address = EmployeeAddressSerializer()