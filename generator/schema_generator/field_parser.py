from field_name_convertor import convert_field_name
from field_type_parser import convert_field_type


def parse_field(field_def, all_class_names, all_enum_names):
  hash = field_def["name_hash"]
  kind = field_def["kind"]
  networked = field_def["networked"]
  type = field_def["templated"] if "templated" in field_def else field_def["type"]

  impl_type, is_value_type = convert_field_type(type, kind, all_class_names, all_enum_names)
  
  if not is_value_type:
    interface_type, is_value_type = convert_field_type(type, kind, all_class_names, all_enum_names, interface = True)
  else:
    interface_type = impl_type

  if kind == "ptr" and type == "char":
    kind = "ref"

  data = {
    "HASH": '0x{:02X}'.format(hash),
    "NAME": convert_field_name(field_def["name"]),
    "IS_NETWORKED": "true" if networked else "false",
    "IMPL_TYPE": impl_type,
    "INTERFACE_TYPE": interface_type,
    "IS_VALUE_TYPE": is_value_type,
    "KIND": kind
  }

  if kind == "fixed_array":
    data["ELEMENT_COUNT"] = field_def["element_count"]
    data["ELEMENT_SIZE"] = field_def["element_size"]
    data["ELEMENT_ALIGNMENT"] = field_def["element_alignment"]

  return data