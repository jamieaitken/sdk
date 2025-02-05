//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//
// @dart=2.12

// ignore_for_file: unused_element, unused_import
// ignore_for_file: always_put_required_named_parameters_first
// ignore_for_file: constant_identifier_names
// ignore_for_file: lines_longer_than_80_chars

part of openapi.api;

class IdentitySchemaContainer {
  /// Returns a new [IdentitySchemaContainer] instance.
  IdentitySchemaContainer({
    this.id,
    this.schema,
  });

  /// The ID of the Identity JSON Schema
  ///
  /// Please note: This property should have been non-nullable! Since the specification file
  /// does not include a default value (using the "default:" property), however, the generated
  /// source code must fall back to having a nullable type.
  /// Consider adding a "default:" property in the specification file to hide this note.
  ///
  String? id;

  /// Raw JSON Schema
  ///
  /// Please note: This property should have been non-nullable! Since the specification file
  /// does not include a default value (using the "default:" property), however, the generated
  /// source code must fall back to having a nullable type.
  /// Consider adding a "default:" property in the specification file to hide this note.
  ///
  Object? schema;

  @override
  bool operator ==(Object other) => identical(this, other) || other is IdentitySchemaContainer &&
     other.id == id &&
     other.schema == schema;

  @override
  int get hashCode =>
    // ignore: unnecessary_parenthesis
    (id == null ? 0 : id!.hashCode) +
    (schema == null ? 0 : schema!.hashCode);

  @override
  String toString() => 'IdentitySchemaContainer[id=$id, schema=$schema]';

  Map<String, dynamic> toJson() {
    final _json = <String, dynamic>{};
    if (id != null) {
      _json[r'id'] = id;
    } else {
      _json[r'id'] = null;
    }
    if (schema != null) {
      _json[r'schema'] = schema;
    } else {
      _json[r'schema'] = null;
    }
    return _json;
  }

  /// Returns a new [IdentitySchemaContainer] instance and imports its values from
  /// [value] if it's a [Map], null otherwise.
  // ignore: prefer_constructors_over_static_methods
  static IdentitySchemaContainer? fromJson(dynamic value) {
    if (value is Map) {
      final json = value.cast<String, dynamic>();

      // Ensure that the map contains the required keys.
      // Note 1: the values aren't checked for validity beyond being non-null.
      // Note 2: this code is stripped in release mode!
      assert(() {
        requiredKeys.forEach((key) {
          assert(json.containsKey(key), 'Required key "IdentitySchemaContainer[$key]" is missing from JSON.');
          assert(json[key] != null, 'Required key "IdentitySchemaContainer[$key]" has a null value in JSON.');
        });
        return true;
      }());

      return IdentitySchemaContainer(
        id: mapValueOfType<String>(json, r'id'),
        schema: mapValueOfType<Object>(json, r'schema'),
      );
    }
    return null;
  }

  static List<IdentitySchemaContainer>? listFromJson(dynamic json, {bool growable = false,}) {
    final result = <IdentitySchemaContainer>[];
    if (json is List && json.isNotEmpty) {
      for (final row in json) {
        final value = IdentitySchemaContainer.fromJson(row);
        if (value != null) {
          result.add(value);
        }
      }
    }
    return result.toList(growable: growable);
  }

  static Map<String, IdentitySchemaContainer> mapFromJson(dynamic json) {
    final map = <String, IdentitySchemaContainer>{};
    if (json is Map && json.isNotEmpty) {
      json = json.cast<String, dynamic>(); // ignore: parameter_assignments
      for (final entry in json.entries) {
        final value = IdentitySchemaContainer.fromJson(entry.value);
        if (value != null) {
          map[entry.key] = value;
        }
      }
    }
    return map;
  }

  // maps a json object with a list of IdentitySchemaContainer-objects as value to a dart map
  static Map<String, List<IdentitySchemaContainer>> mapListFromJson(dynamic json, {bool growable = false,}) {
    final map = <String, List<IdentitySchemaContainer>>{};
    if (json is Map && json.isNotEmpty) {
      json = json.cast<String, dynamic>(); // ignore: parameter_assignments
      for (final entry in json.entries) {
        final value = IdentitySchemaContainer.listFromJson(entry.value, growable: growable,);
        if (value != null) {
          map[entry.key] = value;
        }
      }
    }
    return map;
  }

  /// The list of required keys that must be present in a JSON.
  static const requiredKeys = <String>{
  };
}

