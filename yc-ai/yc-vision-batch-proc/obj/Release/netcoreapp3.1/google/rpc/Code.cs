// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/rpc/code.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Rpc {

  /// <summary>Holder for reflection information generated from google/rpc/code.proto</summary>
  public static partial class CodeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/rpc/code.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CodeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVnb29nbGUvcnBjL2NvZGUucHJvdG8SCmdvb2dsZS5ycGMqtwIKBENvZGUS",
            "BgoCT0sQABINCglDQU5DRUxMRUQQARILCgdVTktOT1dOEAISFAoQSU5WQUxJ",
            "RF9BUkdVTUVOVBADEhUKEURFQURMSU5FX0VYQ0VFREVEEAQSDQoJTk9UX0ZP",
            "VU5EEAUSEgoOQUxSRUFEWV9FWElTVFMQBhIVChFQRVJNSVNTSU9OX0RFTklF",
            "RBAHEhMKD1VOQVVUSEVOVElDQVRFRBAQEhYKElJFU09VUkNFX0VYSEFVU1RF",
            "RBAIEhcKE0ZBSUxFRF9QUkVDT05ESVRJT04QCRILCgdBQk9SVEVEEAoSEAoM",
            "T1VUX09GX1JBTkdFEAsSEQoNVU5JTVBMRU1FTlRFRBAMEgwKCElOVEVSTkFM",
            "EA0SDwoLVU5BVkFJTEFCTEUQDhINCglEQVRBX0xPU1MQD0JYCg5jb20uZ29v",
            "Z2xlLnJwY0IJQ29kZVByb3RvUAFaM2dvb2dsZS5nb2xhbmcub3JnL2dlbnBy",
            "b3RvL2dvb2dsZWFwaXMvcnBjL2NvZGU7Y29kZaICA1JQQ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Rpc.Code), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// The canonical error codes for Google APIs.
  ///
  /// Sometimes multiple error codes may apply.  Services should return
  /// the most specific error code that applies.  For example, prefer
  /// `OUT_OF_RANGE` over `FAILED_PRECONDITION` if both codes apply.
  /// Similarly prefer `NOT_FOUND` or `ALREADY_EXISTS` over `FAILED_PRECONDITION`.
  /// </summary>
  public enum Code {
    /// <summary>
    /// Not an error; returned on success
    ///
    /// HTTP Mapping: 200 OK
    /// </summary>
    [pbr::OriginalName("OK")] Ok = 0,
    /// <summary>
    /// The operation was cancelled, typically by the caller.
    ///
    /// HTTP Mapping: 499 Client Closed Request
    /// </summary>
    [pbr::OriginalName("CANCELLED")] Cancelled = 1,
    /// <summary>
    /// Unknown error.  For example, this error may be returned when
    /// a `Status` value received from another address space belongs to
    /// an error space that is not known in this address space.  Also
    /// errors raised by APIs that do not return enough error information
    /// may be converted to this error.
    ///
    /// HTTP Mapping: 500 Internal Server Error
    /// </summary>
    [pbr::OriginalName("UNKNOWN")] Unknown = 2,
    /// <summary>
    /// The client specified an invalid argument.  Note that this differs
    /// from `FAILED_PRECONDITION`.  `INVALID_ARGUMENT` indicates arguments
    /// that are problematic regardless of the state of the system
    /// (e.g., a malformed file name).
    ///
    /// HTTP Mapping: 400 Bad Request
    /// </summary>
    [pbr::OriginalName("INVALID_ARGUMENT")] InvalidArgument = 3,
    /// <summary>
    /// The deadline expired before the operation could complete. For operations
    /// that change the state of the system, this error may be returned
    /// even if the operation has completed successfully.  For example, a
    /// successful response from a server could have been delayed long
    /// enough for the deadline to expire.
    ///
    /// HTTP Mapping: 504 Gateway Timeout
    /// </summary>
    [pbr::OriginalName("DEADLINE_EXCEEDED")] DeadlineExceeded = 4,
    /// <summary>
    /// Some requested entity (e.g., file or directory) was not found.
    ///
    /// Note to server developers: if a request is denied for an entire class
    /// of users, such as gradual feature rollout or undocumented whitelist,
    /// `NOT_FOUND` may be used. If a request is denied for some users within
    /// a class of users, such as user-based access control, `PERMISSION_DENIED`
    /// must be used.
    ///
    /// HTTP Mapping: 404 Not Found
    /// </summary>
    [pbr::OriginalName("NOT_FOUND")] NotFound = 5,
    /// <summary>
    /// The entity that a client attempted to create (e.g., file or directory)
    /// already exists.
    ///
    /// HTTP Mapping: 409 Conflict
    /// </summary>
    [pbr::OriginalName("ALREADY_EXISTS")] AlreadyExists = 6,
    /// <summary>
    /// The caller does not have permission to execute the specified
    /// operation. `PERMISSION_DENIED` must not be used for rejections
    /// caused by exhausting some resource (use `RESOURCE_EXHAUSTED`
    /// instead for those errors). `PERMISSION_DENIED` must not be
    /// used if the caller can not be identified (use `UNAUTHENTICATED`
    /// instead for those errors). This error code does not imply the
    /// request is valid or the requested entity exists or satisfies
    /// other pre-conditions.
    ///
    /// HTTP Mapping: 403 Forbidden
    /// </summary>
    [pbr::OriginalName("PERMISSION_DENIED")] PermissionDenied = 7,
    /// <summary>
    /// The request does not have valid authentication credentials for the
    /// operation.
    ///
    /// HTTP Mapping: 401 Unauthorized
    /// </summary>
    [pbr::OriginalName("UNAUTHENTICATED")] Unauthenticated = 16,
    /// <summary>
    /// Some resource has been exhausted, perhaps a per-user quota, or
    /// perhaps the entire file system is out of space.
    ///
    /// HTTP Mapping: 429 Too Many Requests
    /// </summary>
    [pbr::OriginalName("RESOURCE_EXHAUSTED")] ResourceExhausted = 8,
    /// <summary>
    /// The operation was rejected because the system is not in a state
    /// required for the operation's execution.  For example, the directory
    /// to be deleted is non-empty, an rmdir operation is applied to
    /// a non-directory, etc.
    ///
    /// Service implementors can use the following guidelines to decide
    /// between `FAILED_PRECONDITION`, `ABORTED`, and `UNAVAILABLE`:
    ///  (a) Use `UNAVAILABLE` if the client can retry just the failing call.
    ///  (b) Use `ABORTED` if the client should retry at a higher level
    ///      (e.g., when a client-specified test-and-set fails, indicating the
    ///      client should restart a read-modify-write sequence).
    ///  (c) Use `FAILED_PRECONDITION` if the client should not retry until
    ///      the system state has been explicitly fixed.  E.g., if an "rmdir"
    ///      fails because the directory is non-empty, `FAILED_PRECONDITION`
    ///      should be returned since the client should not retry unless
    ///      the files are deleted from the directory.
    ///
    /// HTTP Mapping: 400 Bad Request
    /// </summary>
    [pbr::OriginalName("FAILED_PRECONDITION")] FailedPrecondition = 9,
    /// <summary>
    /// The operation was aborted, typically due to a concurrency issue such as
    /// a sequencer check failure or transaction abort.
    ///
    /// See the guidelines above for deciding between `FAILED_PRECONDITION`,
    /// `ABORTED`, and `UNAVAILABLE`.
    ///
    /// HTTP Mapping: 409 Conflict
    /// </summary>
    [pbr::OriginalName("ABORTED")] Aborted = 10,
    /// <summary>
    /// The operation was attempted past the valid range.  E.g., seeking or
    /// reading past end-of-file.
    ///
    /// Unlike `INVALID_ARGUMENT`, this error indicates a problem that may
    /// be fixed if the system state changes. For example, a 32-bit file
    /// system will generate `INVALID_ARGUMENT` if asked to read at an
    /// offset that is not in the range [0,2^32-1], but it will generate
    /// `OUT_OF_RANGE` if asked to read from an offset past the current
    /// file size.
    ///
    /// There is a fair bit of overlap between `FAILED_PRECONDITION` and
    /// `OUT_OF_RANGE`.  We recommend using `OUT_OF_RANGE` (the more specific
    /// error) when it applies so that callers who are iterating through
    /// a space can easily look for an `OUT_OF_RANGE` error to detect when
    /// they are done.
    ///
    /// HTTP Mapping: 400 Bad Request
    /// </summary>
    [pbr::OriginalName("OUT_OF_RANGE")] OutOfRange = 11,
    /// <summary>
    /// The operation is not implemented or is not supported/enabled in this
    /// service.
    ///
    /// HTTP Mapping: 501 Not Implemented
    /// </summary>
    [pbr::OriginalName("UNIMPLEMENTED")] Unimplemented = 12,
    /// <summary>
    /// Internal errors.  This means that some invariants expected by the
    /// underlying system have been broken.  This error code is reserved
    /// for serious errors.
    ///
    /// HTTP Mapping: 500 Internal Server Error
    /// </summary>
    [pbr::OriginalName("INTERNAL")] Internal = 13,
    /// <summary>
    /// The service is currently unavailable.  This is most likely a
    /// transient condition, which can be corrected by retrying with
    /// a backoff.
    ///
    /// See the guidelines above for deciding between `FAILED_PRECONDITION`,
    /// `ABORTED`, and `UNAVAILABLE`.
    ///
    /// HTTP Mapping: 503 Service Unavailable
    /// </summary>
    [pbr::OriginalName("UNAVAILABLE")] Unavailable = 14,
    /// <summary>
    /// Unrecoverable data loss or corruption.
    ///
    /// HTTP Mapping: 500 Internal Server Error
    /// </summary>
    [pbr::OriginalName("DATA_LOSS")] DataLoss = 15,
  }

  #endregion

}

#endregion Designer generated code