//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//
// @dart=2.12

// ignore_for_file: unused_element, unused_import
// ignore_for_file: always_put_required_named_parameters_first
// ignore_for_file: constant_identifier_names
// ignore_for_file: lines_longer_than_80_chars

part of openapi.api;

class ManagedIdentitySchemaValidationResult {
  /// Returns a new [ManagedIdentitySchemaValidationResult] instance.
  ManagedIdentitySchemaValidationResult({
    this.message,
    this.valid,
  });

  ///
  /// Please note: This property should have been non-nullable! Since the specification file
  /// does not include a default value (using the "default:" property), however, the generated
  /// source code must fall back to having a nullable type.
  /// Consider adding a "default:" property in the specification file to hide this note.
  ///
  String? message;

  ///
  /// Please note: This property should have been non-nullable! Since the specification file
  /// does not include a default value (using the "default:" property), however, the generated
  /// source code must fall back to having a nullable type.
  /// Consider adding a "default:" property in the specification file to hide this note.
  ///
  bool? valid;

  @override
  bool operator ==(Object other) => identical(this, other) || other is ManagedIdentitySchemaValidationResult &&
     other.message == message &&
     other.valid == valid;

  @override
  int get hashCode =>
    // ignore: unnecessary_parenthesis
    (message == null ? 0 : message!.hashCode) +
    (valid == null ? 0 : valid!.hashCode);

  @override
  String toString() => 'ManagedIdentitySchemaValidationResult[message=$message, valid=$valid]';

  Map<String, dynamic> toJson() {
    final _json = <String, dynamic>{};
    if (message != null) {
      _json[r'message'] = message;
    } else {
      _json[r'message'] = null;
    }
    if (valid != null) {
      _json[r'valid'] = valid;
    } else {
      _json[r'valid'] = null;
    }
    return _json;
  }

  /// Returns a new [ManagedIdentitySchemaValidationResult] instance and imports its values from
  /// [value] if it's a [Map], null otherwise.
  // ignore: prefer_constructors_over_static_methods
  static ManagedIdentitySchemaValidationResult? fromJson(dynamic value) {
    if (value is Map) {
      final json = value.cast<String, dynamic>();

      // Ensure that the map contains the required keys.
      // Note 1: the values aren't checked for validity beyond being non-null.
      // Note 2: this code is stripped in release mode!
      assert(() {
        requiredKeys.forEach((key) {
          assert(json.containsKey(key), 'Required key "ManagedIdentitySchemaValidationResult[$key]" is missing from JSON.');
          assert(json[key] != null, 'Required key "ManagedIdentitySchemaValidationResult[$key]" has a null value in JSON.');
        });
        return true;
      }());

      return ManagedIdentitySchemaValidationResult(
        message: mapValueOfType<String>(json, r'message'),
        valid: mapValueOfType<bool>(json, r'valid'),
      );
    }
    return null;
  }

  static List<ManagedIdentitySchemaValidationResult>? listFromJson(dynamic json, {bool growable = false,}) {
    final result = <ManagedIdentitySchemaValidationResult>[];
    if (json is List && json.isNotEmpty) {
      for (final row in json) {
        final value = ManagedIdentitySchemaValidationResult.fromJson(row);
        if (value != null) {
          result.add(value);
        }
      }
    }
    return result.toList(growable: growable);
  }

  static Map<String, ManagedIdentitySchemaValidationResult> mapFromJson(dynamic json) {
    final map = <String, ManagedIdentitySchemaValidationResult>{};
    if (json is Map && json.isNotEmpty) {
      json = json.cast<String, dynamic>(); // ignore: parameter_assignments
      for (final entry in json.entries) {
        final value = ManagedIdentitySchemaValidationResult.fromJson(entry.value);
        if (value != null) {
          map[entry.key] = value;
        }
      }
    }
    return map;
  }

  // maps a json object with a list of ManagedIdentitySchemaValidationResult-objects as value to a dart map
  static Map<String, List<ManagedIdentitySchemaValidationResult>> mapListFromJson(dynamic json, {bool growable = false,}) {
    final map = <String, List<ManagedIdentitySchemaValidationResult>>{};
    if (json is Map && json.isNotEmpty) {
      json = json.cast<String, dynamic>(); // ignore: parameter_assignments
      for (final entry in json.entries) {
        final value = ManagedIdentitySchemaValidationResult.listFromJson(entry.value, growable: growable,);
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

