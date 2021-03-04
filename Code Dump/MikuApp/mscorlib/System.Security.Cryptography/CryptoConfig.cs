using System.Collections;
using System.Runtime.InteropServices;
using Mono.Xml;

namespace System.Security.Cryptography
{
	/// <summary>Accesses the cryptography configuration information.</summary>
	[ComVisible(true)]
	public class CryptoConfig
	{
		private class CryptoHandler : SmallXmlParser.IContentHandler
		{
			private Hashtable algorithms;

			private Hashtable oid;

			private Hashtable names;

			private Hashtable classnames;

			private int level;

			public CryptoHandler(Hashtable algorithms, Hashtable oid)
			{
			}

			public void OnStartParsing(SmallXmlParser parser)
			{
			}

			public void OnEndParsing(SmallXmlParser parser)
			{
			}

			private string Get(SmallXmlParser.IAttrList attrs, string name)
			{
				return (string)/*Error near IL_0001: Stack underflow*/;
			}

			public void OnStartElement(string name, SmallXmlParser.IAttrList attrs)
			{
			}

			public void OnEndElement(string name)
			{
			}

			public void OnProcessingInstruction(string name, string text)
			{
			}

			public void OnChars(string text)
			{
			}

			public void OnIgnorableWhitespace(string text)
			{
			}
		}

		private const string defaultNamespace = "System.Security.Cryptography.";

		private const string defaultSHA1 = "System.Security.Cryptography.SHA1CryptoServiceProvider";

		private const string defaultMD5 = "System.Security.Cryptography.MD5CryptoServiceProvider";

		private const string defaultSHA256 = "System.Security.Cryptography.SHA256Managed";

		private const string defaultSHA384 = "System.Security.Cryptography.SHA384Managed";

		private const string defaultSHA512 = "System.Security.Cryptography.SHA512Managed";

		private const string defaultRSA = "System.Security.Cryptography.RSACryptoServiceProvider";

		private const string defaultDSA = "System.Security.Cryptography.DSACryptoServiceProvider";

		private const string defaultDES = "System.Security.Cryptography.DESCryptoServiceProvider";

		private const string default3DES = "System.Security.Cryptography.TripleDESCryptoServiceProvider";

		private const string defaultRC2 = "System.Security.Cryptography.RC2CryptoServiceProvider";

		private const string defaultAES = "System.Security.Cryptography.RijndaelManaged";

		private const string defaultRNG = "System.Security.Cryptography.RNGCryptoServiceProvider";

		private const string defaultHMAC = "System.Security.Cryptography.HMACSHA1";

		private const string defaultMAC3DES = "System.Security.Cryptography.MACTripleDES";

		private const string defaultDSASigDesc = "System.Security.Cryptography.DSASignatureDescription";

		private const string defaultRSASigDesc = "System.Security.Cryptography.RSAPKCS1SHA1SignatureDescription";

		private const string defaultRIPEMD160 = "System.Security.Cryptography.RIPEMD160Managed";

		private const string defaultHMACMD5 = "System.Security.Cryptography.HMACMD5";

		private const string defaultHMACRIPEMD160 = "System.Security.Cryptography.HMACRIPEMD160";

		private const string defaultHMACSHA256 = "System.Security.Cryptography.HMACSHA256";

		private const string defaultHMACSHA384 = "System.Security.Cryptography.HMACSHA384";

		private const string defaultHMACSHA512 = "System.Security.Cryptography.HMACSHA512";

		private const string defaultC14N = "System.Security.Cryptography.Xml.XmlDsigC14NTransform, System.Security, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string defaultC14NWithComments = "System.Security.Cryptography.Xml.XmlDsigC14NWithCommentsTransform, System.Security, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string defaultBase64 = "System.Security.Cryptography.Xml.XmlDsigBase64Transform, System.Security, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string defaultXPath = "System.Security.Cryptography.Xml.XmlDsigXPathTransform, System.Security, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string defaultXslt = "System.Security.Cryptography.Xml.XmlDsigXsltTransform, System.Security, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string defaultEnveloped = "System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform, System.Security, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string defaultXmlDecryption = "System.Security.Cryptography.Xml.XmlDecryptionTransform, System.Security, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string defaultExcC14N = "System.Security.Cryptography.Xml.XmlDsigExcC14NTransform, System.Security, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string defaultExcC14NWithComments = "System.Security.Cryptography.Xml.XmlDsigExcC14NWithCommentsTransform, System.Security, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string defaultX509Data = "System.Security.Cryptography.Xml.KeyInfoX509Data, System.Security, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string defaultKeyName = "System.Security.Cryptography.Xml.KeyInfoName, System.Security, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string defaultKeyValueDSA = "System.Security.Cryptography.Xml.DSAKeyValue, System.Security, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string defaultKeyValueRSA = "System.Security.Cryptography.Xml.RSAKeyValue, System.Security, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string defaultRetrievalMethod = "System.Security.Cryptography.Xml.KeyInfoRetrievalMethod, System.Security, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string managedSHA1 = "System.Security.Cryptography.SHA1Managed";

		private const string oidSHA1 = "1.3.14.3.2.26";

		private const string oidMD5 = "1.2.840.113549.2.5";

		private const string oidSHA256 = "2.16.840.1.101.3.4.2.1";

		private const string oidSHA384 = "2.16.840.1.101.3.4.2.2";

		private const string oidSHA512 = "2.16.840.1.101.3.4.2.3";

		private const string oidDSA = "1.2.840.10040.4.1";

		private const string oidDES = "1.3.14.3.2.7";

		private const string oid3DES = "1.2.840.113549.3.7";

		private const string oidRC2 = "1.2.840.113549.3.2";

		private const string oid3DESKeyWrap = "1.2.840.113549.1.9.16.3.6";

		private const string nameSHA1a = "SHA";

		private const string nameSHA1b = "SHA1";

		private const string nameSHA1c = "System.Security.Cryptography.SHA1";

		private const string nameSHA1d = "System.Security.Cryptography.HashAlgorithm";

		private const string nameMD5a = "MD5";

		private const string nameMD5b = "System.Security.Cryptography.MD5";

		private const string nameSHA256a = "SHA256";

		private const string nameSHA256b = "SHA-256";

		private const string nameSHA256c = "System.Security.Cryptography.SHA256";

		private const string nameSHA384a = "SHA384";

		private const string nameSHA384b = "SHA-384";

		private const string nameSHA384c = "System.Security.Cryptography.SHA384";

		private const string nameSHA512a = "SHA512";

		private const string nameSHA512b = "SHA-512";

		private const string nameSHA512c = "System.Security.Cryptography.SHA512";

		private const string nameRSAa = "RSA";

		private const string nameRSAb = "System.Security.Cryptography.RSA";

		private const string nameRSAc = "System.Security.Cryptography.AsymmetricAlgorithm";

		private const string nameDSAa = "DSA";

		private const string nameDSAb = "System.Security.Cryptography.DSA";

		private const string nameDESa = "DES";

		private const string nameDESb = "System.Security.Cryptography.DES";

		private const string name3DESa = "3DES";

		private const string name3DESb = "TripleDES";

		private const string name3DESc = "Triple DES";

		private const string name3DESd = "System.Security.Cryptography.TripleDES";

		private const string nameRC2a = "RC2";

		private const string nameRC2b = "System.Security.Cryptography.RC2";

		private const string nameAESa = "Rijndael";

		private const string nameAESb = "System.Security.Cryptography.Rijndael";

		private const string nameAESc = "System.Security.Cryptography.SymmetricAlgorithm";

		private const string nameRNGa = "RandomNumberGenerator";

		private const string nameRNGb = "System.Security.Cryptography.RandomNumberGenerator";

		private const string nameKeyHasha = "System.Security.Cryptography.KeyedHashAlgorithm";

		private const string nameHMACSHA1a = "HMACSHA1";

		private const string nameHMACSHA1b = "System.Security.Cryptography.HMACSHA1";

		private const string nameMAC3DESa = "MACTripleDES";

		private const string nameMAC3DESb = "System.Security.Cryptography.MACTripleDES";

		private const string name3DESKeyWrap = "TripleDESKeyWrap";

		private const string nameRIPEMD160a = "RIPEMD160";

		private const string nameRIPEMD160b = "RIPEMD-160";

		private const string nameRIPEMD160c = "System.Security.Cryptography.RIPEMD160";

		private const string nameHMACa = "HMAC";

		private const string nameHMACb = "System.Security.Cryptography.HMAC";

		private const string nameHMACMD5a = "HMACMD5";

		private const string nameHMACMD5b = "System.Security.Cryptography.HMACMD5";

		private const string nameHMACRIPEMD160a = "HMACRIPEMD160";

		private const string nameHMACRIPEMD160b = "System.Security.Cryptography.HMACRIPEMD160";

		private const string nameHMACSHA256a = "HMACSHA256";

		private const string nameHMACSHA256b = "System.Security.Cryptography.HMACSHA256";

		private const string nameHMACSHA384a = "HMACSHA384";

		private const string nameHMACSHA384b = "System.Security.Cryptography.HMACSHA384";

		private const string nameHMACSHA512a = "HMACSHA512";

		private const string nameHMACSHA512b = "System.Security.Cryptography.HMACSHA512";

		private const string urlXmlDsig = "http://www.w3.org/2000/09/xmldsig#";

		private const string urlDSASHA1 = "http://www.w3.org/2000/09/xmldsig#dsa-sha1";

		private const string urlRSASHA1 = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";

		private const string urlSHA1 = "http://www.w3.org/2000/09/xmldsig#sha1";

		private const string urlC14N = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";

		private const string urlC14NWithComments = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315#WithComments";

		private const string urlBase64 = "http://www.w3.org/2000/09/xmldsig#base64";

		private const string urlXPath = "http://www.w3.org/TR/1999/REC-xpath-19991116";

		private const string urlXslt = "http://www.w3.org/TR/1999/REC-xslt-19991116";

		private const string urlEnveloped = "http://www.w3.org/2000/09/xmldsig#enveloped-signature";

		private const string urlXmlDecryption = "http://www.w3.org/2002/07/decrypt#XML";

		private const string urlExcC14NWithComments = "http://www.w3.org/2001/10/xml-exc-c14n#WithComments";

		private const string urlExcC14N = "http://www.w3.org/2001/10/xml-exc-c14n#";

		private const string urlSHA256 = "http://www.w3.org/2001/04/xmlenc#sha256";

		private const string urlSHA512 = "http://www.w3.org/2001/04/xmlenc#sha512";

		private const string urlHMACSHA256 = "http://www.w3.org/2001/04/xmldsig-more#hmac-sha256";

		private const string urlHMACSHA384 = "http://www.w3.org/2001/04/xmldsig-more#hmac-sha384";

		private const string urlHMACSHA512 = "http://www.w3.org/2001/04/xmldsig-more#hmac-sha512";

		private const string urlHMACRIPEMD160 = "http://www.w3.org/2001/04/xmldsig-more#hmac-ripemd160";

		private const string urlX509Data = "http://www.w3.org/2000/09/xmldsig# X509Data";

		private const string urlKeyName = "http://www.w3.org/2000/09/xmldsig# KeyName";

		private const string urlKeyValueDSA = "http://www.w3.org/2000/09/xmldsig# KeyValue/DSAKeyValue";

		private const string urlKeyValueRSA = "http://www.w3.org/2000/09/xmldsig# KeyValue/RSAKeyValue";

		private const string urlRetrievalMethod = "http://www.w3.org/2000/09/xmldsig# RetrievalMethod";

		private const string oidX509SubjectKeyIdentifier = "2.5.29.14";

		private const string oidX509KeyUsage = "2.5.29.15";

		private const string oidX509BasicConstraints = "2.5.29.19";

		private const string oidX509EnhancedKeyUsage = "2.5.29.37";

		private const string nameX509SubjectKeyIdentifier = "System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension, System, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

		private const string nameX509KeyUsage = "System.Security.Cryptography.X509Certificates.X509KeyUsageExtension, System, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

		private const string nameX509BasicConstraints = "System.Security.Cryptography.X509Certificates.X509BasicConstraintsExtension, System, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

		private const string nameX509EnhancedKeyUsage = "System.Security.Cryptography.X509Certificates.X509EnhancedKeyUsageExtension, System, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

		private const string nameX509Chain = "X509Chain";

		private const string defaultX509Chain = "System.Security.Cryptography.X509Certificates.X509Chain, System, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

		private static object lockObject;

		private static Hashtable algorithms;

		private static Hashtable oid;

		static CryptoConfig()
		{
		}

		private static void Initialize()
		{
		}

		private static void LoadConfig(string filename, Hashtable algorithms, Hashtable oid)
		{
		}

		/// <summary>Creates a new instance of the specified cryptographic object.</summary>
		/// <returns>A new instance of the specified cryptographic object.</returns>
		/// <param name="name">The simple name of the cryptographic object of which to create an instance. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">The algorithm described by the <paramref name="name" /> parameter was used with Federal Information Processing Standards (FIPS) mode enabled, but is not FIPS compatible.</exception>
		public static object CreateFromName(string name)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Creates a new instance of the specified cryptographic object with the specified arguments.</summary>
		/// <returns>A new instance of the specified cryptographic object.</returns>
		/// <param name="name">The simple name of the cryptographic object of which to create an instance. </param>
		/// <param name="args">The arguments used to create the specified cryptographic object. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">The algorithm described by the <paramref name="name" /> parameter was used with Federal Information Processing Standards (FIPS) mode enabled, but is not FIPS compatible.</exception>
		public static object CreateFromName(string name, params object[] args)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
