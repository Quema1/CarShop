//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v11.3.0+a1d6f65
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	// Mixin Content Type with alias "metadata"
	/// <summary>Metadata</summary>
	public partial interface IMetadata : IPublishedElement
	{
		/// <summary>Keywords</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::System.Collections.Generic.IEnumerable<string> Keywords { get; }

		/// <summary>Page Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string PageDescription { get; }

		/// <summary>Page Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string PageTitle { get; }
	}

	/// <summary>Metadata</summary>
	[PublishedModel("metadata")]
	public partial class Metadata : PublishedElementModel, IMetadata
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		public new const string ModelTypeAlias = "metadata";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Metadata, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Metadata(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Keywords
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("keywords")]
		public virtual global::System.Collections.Generic.IEnumerable<string> Keywords => GetKeywords(this, _publishedValueFallback);

		/// <summary>Static getter for Keywords</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::System.Collections.Generic.IEnumerable<string> GetKeywords(IMetadata that, IPublishedValueFallback publishedValueFallback) => that.Value<global::System.Collections.Generic.IEnumerable<string>>(publishedValueFallback, "keywords");

		///<summary>
		/// Page Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageDescription")]
		public virtual string PageDescription => GetPageDescription(this, _publishedValueFallback);

		/// <summary>Static getter for Page Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetPageDescription(IMetadata that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "pageDescription");

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => GetPageTitle(this, _publishedValueFallback);

		/// <summary>Static getter for Page Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetPageTitle(IMetadata that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "pageTitle");
	}
}
