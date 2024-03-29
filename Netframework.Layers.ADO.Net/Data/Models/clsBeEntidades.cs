using System;
using System.Windows;
using System.Data.SqlClient;

namespace Netframework.Layers.ADO.Net.Data.Models
{
	public class clsBeEntidades : ICloneable
	{

		private int mIdEntidad = 0;
		private string mDescripcion = "";
		private string mDireccion = "";
		private string mLocalidad = "";
		private string mTipoEntidad = "";
		private string mTipoDocumento = "";
		private int mNumeroDocumento = 0;
		private string mTeléfonos = "";
		private string mURLPaginaWeb = "";
		private string mURLFacebook = "";
		private string mURLInstagram = "";
		private string mURLTwitter = "";
		private string mURLTikTok = "";
		private int mIdGrupoEntidad = 0;
		private int mIdTipoEntidad = 0;
		private int mLimiteCredito = 0;
		private string mUserNameEntidad = "";
		private string mPassworEntidad = "";
		private string mRolUserEntidad = "";
		private string mComentario = "";
		private string mStatuss = "";
		private bool mNoEliminable = false;
		private DateTime mFechaRegistro = DateTime.Now;

		public int IdEntidad
		{
			get
			{
				return mIdEntidad;
			}
			set
			{
				mIdEntidad = value;
			}
		}

		public string Descripcion
		{
			get
			{
				return mDescripcion;
			}
			set
			{
				mDescripcion = value;
			}
		}

		public string Direccion
		{
			get
			{
				return mDireccion;
			}
			set
			{
				mDireccion = value;
			}
		}

		public string Localidad
		{
			get
			{
				return mLocalidad;
			}
			set
			{
				mLocalidad = value;
			}
		}

		public string TipoEntidad
		{
			get
			{
				return mTipoEntidad;
			}
			set
			{
				mTipoEntidad = value;
			}
		}

		public string TipoDocumento
		{
			get
			{
				return mTipoDocumento;
			}
			set
			{
				mTipoDocumento = value;
			}
		}

		public int NumeroDocumento
		{
			get
			{
				return mNumeroDocumento;
			}
			set
			{
				mNumeroDocumento = value;
			}
		}

		public string Teléfonos
		{
			get
			{
				return mTeléfonos;
			}
			set
			{
				mTeléfonos = value;
			}
		}

		public string URLPaginaWeb
		{
			get
			{
				return mURLPaginaWeb;
			}
			set
			{
				mURLPaginaWeb = value;
			}
		}

		public string URLFacebook
		{
			get
			{
				return mURLFacebook;
			}
			set
			{
				mURLFacebook = value;
			}
		}

		public string URLInstagram
		{
			get
			{
				return mURLInstagram;
			}
			set
			{
				mURLInstagram = value;
			}
		}

		public string URLTwitter
		{
			get
			{
				return mURLTwitter;
			}
			set
			{
				mURLTwitter = value;
			}
		}

		public string URLTikTok
		{
			get
			{
				return mURLTikTok;
			}
			set
			{
				mURLTikTok = value;
			}
		}

		public int IdGrupoEntidad
		{
			get
			{
				return mIdGrupoEntidad;
			}
			set
			{
				mIdGrupoEntidad = value;
			}
		}

		public int IdTipoEntidad
		{
			get
			{
				return mIdTipoEntidad;
			}
			set
			{
				mIdTipoEntidad = value;
			}
		}

		public int LimiteCredito
		{
			get
			{
				return mLimiteCredito;
			}
			set
			{
				mLimiteCredito = value;
			}
		}

		public string UserNameEntidad
		{
			get
			{
				return mUserNameEntidad;
			}
			set
			{
				mUserNameEntidad = value;
			}
		}

		public string PassworEntidad
		{
			get
			{
				return mPassworEntidad;
			}
			set
			{
				mPassworEntidad = value;
			}
		}

		public string RolUserEntidad
		{
			get
			{
				return mRolUserEntidad;
			}
			set
			{
				mRolUserEntidad = value;
			}
		}

		public string Comentario
		{
			get
			{
				return mComentario;
			}
			set
			{
				mComentario = value;
			}
		}

		public string Statuss
		{
			get
			{
				return mStatuss;
			}
			set
			{
				mStatuss = value;
			}
		}

		public Boolean NoEliminable
		{
			get
			{
				return mNoEliminable;
			}
			set
			{
				mNoEliminable = value;
			}
		}

		public DateTime FechaRegistro
		{
			get
			{
				return mFechaRegistro;
			}
			set
			{
				mFechaRegistro = value;
			}
		}

		public clsBeEntidades()
		{
		}

		public clsBeEntidades(ref int IdEntidad, string Descripcion, string Direccion, string Localidad, string TipoEntidad, string TipoDocumento, int NumeroDocumento, string Teléfonos, string URLPaginaWeb, string URLFacebook, string URLInstagram, string URLTwitter, string URLTikTok, int IdGrupoEntidad, int IdTipoEntidad, int LimiteCredito, string UserNameEntidad, string PassworEntidad, string RolUserEntidad, string Comentario, string Statuss, bool NoEliminable, DateTime FechaRegistro)
		{
			mIdEntidad = IdEntidad;
			mDescripcion = Descripcion;
			mDireccion = Direccion;
			mLocalidad = Localidad;
			mTipoEntidad = TipoEntidad;
			mTipoDocumento = TipoDocumento;
			mNumeroDocumento = NumeroDocumento;
			mTeléfonos = Teléfonos;
			mURLPaginaWeb = URLPaginaWeb;
			mURLFacebook = URLFacebook;
			mURLInstagram = URLInstagram;
			mURLTwitter = URLTwitter;
			mURLTikTok = URLTikTok;
			mIdGrupoEntidad = IdGrupoEntidad;
			mIdTipoEntidad = IdTipoEntidad;
			mLimiteCredito = LimiteCredito;
			mUserNameEntidad = UserNameEntidad;
			mPassworEntidad = PassworEntidad;
			mRolUserEntidad = RolUserEntidad;
			mComentario = Comentario;
			mStatuss = Statuss;
			mNoEliminable = NoEliminable;
            mFechaRegistro = FechaRegistro;
		}

		public object Clone()
		{
			return base.MemberwiseClone();
		}

	}
}

