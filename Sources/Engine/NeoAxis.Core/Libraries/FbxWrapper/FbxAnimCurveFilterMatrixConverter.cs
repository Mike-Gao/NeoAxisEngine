//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Fbx {

public class FbxAnimCurveFilterMatrixConverter : FbxAnimCurveFilter {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxAnimCurveFilterMatrixConverter(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxAnimCurveFilterMatrixConverter obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxAnimCurveFilterMatrixConverter() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxAnimCurveFilterMatrixConverter(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FbxAnimCurveFilterMatrixConverter() : this(FbxWrapperNativePINVOKE.new_FbxAnimCurveFilterMatrixConverter(), true) {
  }

  public override string GetName() {
    string ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_GetName(swigCPtr);
    return ret;
  }

  public override bool NeedApply(SWIGTYPE_p_p_FbxAnimCurve pCurve, int pCount, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_NeedApply__SWIG_0(swigCPtr, SWIGTYPE_p_p_FbxAnimCurve.getCPtr(pCurve), pCount, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public override bool NeedApply(SWIGTYPE_p_p_FbxAnimCurve pCurve, int pCount) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_NeedApply__SWIG_1(swigCPtr, SWIGTYPE_p_p_FbxAnimCurve.getCPtr(pCurve), pCount);
    return ret;
  }

  public override bool NeedApply(FbxAnimCurveNode pCurveNode, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_NeedApply__SWIG_2(swigCPtr, FbxAnimCurveNode.getCPtr(pCurveNode), FbxStatus.getCPtr(pStatus));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool NeedApply(FbxAnimCurveNode pCurveNode) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_NeedApply__SWIG_3(swigCPtr, FbxAnimCurveNode.getCPtr(pCurveNode));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool Apply(FbxAnimCurveNode pCurveNode, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_Apply__SWIG_0(swigCPtr, FbxAnimCurveNode.getCPtr(pCurveNode), FbxStatus.getCPtr(pStatus));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool Apply(FbxAnimCurveNode pCurveNode) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_Apply__SWIG_1(swigCPtr, FbxAnimCurveNode.getCPtr(pCurveNode));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool NeedApply(FbxAnimStack arg0, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_NeedApply__SWIG_4(swigCPtr, FbxAnimStack.getCPtr(arg0), FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public override bool NeedApply(FbxAnimStack arg0) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_NeedApply__SWIG_5(swigCPtr, FbxAnimStack.getCPtr(arg0));
    return ret;
  }

  public override bool NeedApply(FbxObject arg0, FbxAnimStack arg1, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_NeedApply__SWIG_6(swigCPtr, FbxObject.getCPtr(arg0), FbxAnimStack.getCPtr(arg1), FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public override bool NeedApply(FbxObject arg0, FbxAnimStack arg1) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_NeedApply__SWIG_7(swigCPtr, FbxObject.getCPtr(arg0), FbxAnimStack.getCPtr(arg1));
    return ret;
  }

  public virtual bool NeedApply(SWIGTYPE_p_p_FbxAnimCurveNode pCurveNode, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_NeedApply__SWIG_8(swigCPtr, SWIGTYPE_p_p_FbxAnimCurveNode.getCPtr(pCurveNode), FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public virtual bool NeedApply(SWIGTYPE_p_p_FbxAnimCurveNode pCurveNode) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_NeedApply__SWIG_9(swigCPtr, SWIGTYPE_p_p_FbxAnimCurveNode.getCPtr(pCurveNode));
    return ret;
  }

  public override bool NeedApply(FbxAnimCurve arg0, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_NeedApply__SWIG_10(swigCPtr, FbxAnimCurve.getCPtr(arg0), FbxStatus.getCPtr(pStatus));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool NeedApply(FbxAnimCurve arg0) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_NeedApply__SWIG_11(swigCPtr, FbxAnimCurve.getCPtr(arg0));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool Apply(FbxAnimStack arg0, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_Apply__SWIG_2(swigCPtr, FbxAnimStack.getCPtr(arg0), FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public override bool Apply(FbxAnimStack arg0) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_Apply__SWIG_3(swigCPtr, FbxAnimStack.getCPtr(arg0));
    return ret;
  }

  public override bool Apply(FbxObject arg0, FbxAnimStack arg1, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_Apply__SWIG_4(swigCPtr, FbxObject.getCPtr(arg0), FbxAnimStack.getCPtr(arg1), FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public override bool Apply(FbxObject arg0, FbxAnimStack arg1) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_Apply__SWIG_5(swigCPtr, FbxObject.getCPtr(arg0), FbxAnimStack.getCPtr(arg1));
    return ret;
  }

  public virtual bool Apply(SWIGTYPE_p_p_FbxAnimCurveNode pCurveNode, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_Apply__SWIG_6(swigCPtr, SWIGTYPE_p_p_FbxAnimCurveNode.getCPtr(pCurveNode), FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public virtual bool Apply(SWIGTYPE_p_p_FbxAnimCurveNode pCurveNode) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_Apply__SWIG_7(swigCPtr, SWIGTYPE_p_p_FbxAnimCurveNode.getCPtr(pCurveNode));
    return ret;
  }

  public override bool Apply(SWIGTYPE_p_p_FbxAnimCurve pCurve, int pCount, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_Apply__SWIG_8(swigCPtr, SWIGTYPE_p_p_FbxAnimCurve.getCPtr(pCurve), pCount, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public override bool Apply(SWIGTYPE_p_p_FbxAnimCurve pCurve, int pCount) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_Apply__SWIG_9(swigCPtr, SWIGTYPE_p_p_FbxAnimCurve.getCPtr(pCurve), pCount);
    return ret;
  }

  public bool Apply(SWIGTYPE_p_p_FbxAnimCurve pCurve, SWIGTYPE_p_double pVals, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_Apply__SWIG_10(swigCPtr, SWIGTYPE_p_p_FbxAnimCurve.getCPtr(pCurve), SWIGTYPE_p_double.getCPtr(pVals), FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public bool Apply(SWIGTYPE_p_p_FbxAnimCurve pCurve, SWIGTYPE_p_double pVals) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_Apply__SWIG_11(swigCPtr, SWIGTYPE_p_p_FbxAnimCurve.getCPtr(pCurve), SWIGTYPE_p_double.getCPtr(pVals));
    return ret;
  }

  public override bool Apply(FbxAnimCurve arg0, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_Apply__SWIG_12(swigCPtr, FbxAnimCurve.getCPtr(arg0), FbxStatus.getCPtr(pStatus));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool Apply(FbxAnimCurve arg0) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_Apply__SWIG_13(swigCPtr, FbxAnimCurve.getCPtr(arg0));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Reset() {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_Reset(swigCPtr);
  }

  public void GetSourceMatrix(FbxAnimCurveFilterMatrixConverter.EMatrixIndex pIndex, FbxAMatrix pMatrix) {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_GetSourceMatrix(swigCPtr, (int)pIndex, FbxAMatrix.getCPtr(pMatrix));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSourceMatrix(FbxAnimCurveFilterMatrixConverter.EMatrixIndex pIndex, FbxAMatrix pMatrix) {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_SetSourceMatrix(swigCPtr, (int)pIndex, FbxAMatrix.getCPtr(pMatrix));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetDestMatrix(FbxAnimCurveFilterMatrixConverter.EMatrixIndex pIndex, FbxAMatrix pMatrix) {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_GetDestMatrix(swigCPtr, (int)pIndex, FbxAMatrix.getCPtr(pMatrix));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDestMatrix(FbxAnimCurveFilterMatrixConverter.EMatrixIndex pIndex, FbxAMatrix pMatrix) {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_SetDestMatrix(swigCPtr, (int)pIndex, FbxAMatrix.getCPtr(pMatrix));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxTime GetResamplingPeriod() {
    FbxTime ret = new FbxTime(FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_GetResamplingPeriod(swigCPtr), true);
    return ret;
  }

  public void SetResamplingPeriod(FbxTime pResamplingPeriod) {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_SetResamplingPeriod(swigCPtr, FbxTime.getCPtr(pResamplingPeriod));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetGenerateLastKeyExactlyAtEndTime() {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_GetGenerateLastKeyExactlyAtEndTime(swigCPtr);
    return ret;
  }

  public void SetGenerateLastKeyExactlyAtEndTime(bool pFlag) {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_SetGenerateLastKeyExactlyAtEndTime(swigCPtr, pFlag);
  }

  public bool GetResamplingOnFrameRateMultiple() {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_GetResamplingOnFrameRateMultiple(swigCPtr);
    return ret;
  }

  public void SetResamplingOnFrameRateMultiple(bool pFlag) {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_SetResamplingOnFrameRateMultiple(swigCPtr, pFlag);
  }

  public bool GetApplyUnroll() {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_GetApplyUnroll(swigCPtr);
    return ret;
  }

  public void SetApplyUnroll(bool pFlag) {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_SetApplyUnroll(swigCPtr, pFlag);
  }

  public bool GetApplyConstantKeyReducer() {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_GetApplyConstantKeyReducer(swigCPtr);
    return ret;
  }

  public void SetApplyConstantKeyReducer(bool pFlag) {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_SetApplyConstantKeyReducer(swigCPtr, pFlag);
  }

  public bool GetResampleTranslation() {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_GetResampleTranslation(swigCPtr);
    return ret;
  }

  public void SetResampleTranslation(bool pFlag) {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_SetResampleTranslation(swigCPtr, pFlag);
  }

  public void SetSrcRotateOrder(FbxEuler.EOrder pOrder) {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_SetSrcRotateOrder(swigCPtr, (int)pOrder);
  }

  public void SetDestRotateOrder(FbxEuler.EOrder pOrder) {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_SetDestRotateOrder(swigCPtr, (int)pOrder);
  }

  public void SetForceApply(bool pVal) {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_SetForceApply(swigCPtr, pVal);
  }

  public bool GetForceApply() {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_GetForceApply(swigCPtr);
    return ret;
  }

  public void SetTranslationLimits(FbxLimits limit) {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_SetTranslationLimits(swigCPtr, FbxLimits.getCPtr(limit));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRotationLimits(FbxLimits limit) {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_SetRotationLimits(swigCPtr, FbxLimits.getCPtr(limit));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetScalingLimits(FbxLimits limit) {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilterMatrixConverter_SetScalingLimits(swigCPtr, FbxLimits.getCPtr(limit));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public enum EMatrixIndex {
    ePreGlobal,
    ePreTranslate,
    ePostTranslate,
    ePreRotate,
    ePostRotate,
    ePreScale,
    ePostScale,
    ePostGlobal,
    eScaleOffset,
    eInactivePre,
    eInactivePost,
    eRotationPivot,
    eScalingPivot,
    eMatrixIndexCount
  }

}

}