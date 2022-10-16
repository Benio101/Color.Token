using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace Color.Token
{
	internal static class Definitions
	{
		#pragma warning disable 169
		#pragma warning disable IDE0051

		// > The field is never used
		// Reason: The field is used by MEF.

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.alignas")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_alignas;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.alignof")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_alignof;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.asm")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_asm;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.atomic_cancel")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_atomic_cancel;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.atomic_commit")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_atomic_commit;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.atomic_noexcept")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_atomic_noexcept;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.auto")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_auto;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.bool")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_bool;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.break")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_break;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.case")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_case;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.catch")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_catch;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.char")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_char;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.char8_t")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_char8_t;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.char16_t")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_char16_t;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.char32_t")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_char32_t;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.class")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_class;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.concept")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_concept;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.const")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_const;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.consteval")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_consteval;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.constexpr")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_constexpr;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.constinit")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_constinit;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.const_cast")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_const_cast;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.continue")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_continue;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.co_await")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_co_await;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.co_return")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_co_return;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.co_yield")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_co_yield;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.decltype")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_decltype;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.default")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_default;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.default.statement")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_default_statement;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.delete")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_delete;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.do")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_do;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.double")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_double;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.dynamic_cast")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_dynamic_cast;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.else")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_else;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.enum")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_enum;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.explicit")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_explicit;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.export")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_export;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.extern")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_extern;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.false")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_false;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.final")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_final;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.float")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_float;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.for")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_for;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.friend")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_friend;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.goto")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_goto;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.if")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_if;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.import")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_import;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.inline")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_inline;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.int")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_int;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.long")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_long;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.module")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_module;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.mutable")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_mutable;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.namespace")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_namespace;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.new")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_new;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.noexcept")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_noexcept;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.nullptr")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_nullptr;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.operator")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_operator;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.private")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_private;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.protected")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_protected;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.public")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_public;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.override")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_override;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.reflexpr")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_reflexpr;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.reinterpret_cast")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_reinterpret_cast;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.requires")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_requires;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.return")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_return;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.short")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_short;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.signed")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_signed;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.sizeof")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_sizeof;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.static")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_static;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.static_assert")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_static_assert;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.static_cast")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_static_cast;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.struct")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_struct;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.switch")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_switch;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.synchronized")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_synchronized;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.template")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_template;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.this")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_this;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.thread_local")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_thread_local;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.throw")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_throw;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.transaction_safe")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_transaction_safe;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.transaction_safe_dynamic")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_transaction_safe_dynamic;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.true")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_true;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.try")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_try;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.typedef")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_typedef;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.typeid")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_typeid;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.typename")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_typename;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.union")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_union;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.unsigned")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_unsigned;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.using")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_using;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.virtual")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_virtual;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.void")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_void;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.volatile")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_volatile;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.wchar_t")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_wchar_t;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Token.while")]
		private static readonly ClassificationTypeDefinition
		Definition_Token_while;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Token.FRotator")]
        private static readonly ClassificationTypeDefinition
        Definition_Token_FRotator;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Token.FString")]
        private static readonly ClassificationTypeDefinition
        Definition_Token_FString;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Token.FText")]
        private static readonly ClassificationTypeDefinition
        Definition_Token_FText;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Token.FTransform")]
        private static readonly ClassificationTypeDefinition
        Definition_Token_FTransform;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Token.FVector")]
        private static readonly ClassificationTypeDefinition
        Definition_Token_FVector;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Token.FVector2D")]
        private static readonly ClassificationTypeDefinition
        Definition_Token_FVector2D;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Token.int32")]
        private static readonly ClassificationTypeDefinition
        Definition_Token_int32;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Token.int8")]
        private static readonly ClassificationTypeDefinition
        Definition_Token_int8;

		#pragma warning restore IDE0051
		#pragma warning restore 169
    }
}