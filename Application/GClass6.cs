using System;

// Token: 0x0200002E RID: 46
[Serializable]
public abstract class GClass6
{
	// Token: 0x060002A2 RID: 674 RVA: 0x01036DF4 File Offset: 0x01034FF4
	public virtual void vmethod_0()
	{
		this._lasterror = null;
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x01036E08 File Offset: 0x01035008
	public virtual Exception vmethod_1()
	{
		return this._lasterror;
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x01036E1C File Offset: 0x0103501C
	protected virtual bool vmethod_2(Exception exception_0)
	{
		this._lasterror = exception_0;
		return false;
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x01036E34 File Offset: 0x01035034
	protected virtual bool vmethod_3(string string_0)
	{
		return this.vmethod_2(new Exception(string_0));
	}

	// Token: 0x04000175 RID: 373
	protected Exception _lasterror;
}
