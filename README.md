# <img align="right" src="https://raw.githubusercontent.com/Benio101/Color.Token/2022/Color.Token/Logo.ico"> Color.Token
[Visual Studio](https://visualstudio.microsoft.com) extension: Color C++ Tokens.

## Status
| Branch | Build Status
| ---    | ---
| [`2022`](https://github.com/Benio101/Color.Token/tree/2022) | [![Build status](https://ci.appveyor.com/api/projects/status/fduwr8hv17jn39lo/branch/2022?svg=true)](https://ci.appveyor.com/project/Benio101/color-token/branch/2022)
| [`2019`](https://github.com/Benio101/Color.Token/tree/2019) | [![Build status](https://ci.appveyor.com/api/projects/status/fduwr8hv17jn39lo/branch/2019?svg=true)](https://ci.appveyor.com/project/Benio101/color-token/branch/2019)
| [`2017`](https://github.com/Benio101/Color.Token/tree/2017) | [![Build status](https://ci.appveyor.com/api/projects/status/fduwr8hv17jn39lo/branch/2017?svg=true)](https://ci.appveyor.com/project/Benio101/color-token/branch/2017)

## Description
Extension adds options to overwrite colors of certain C++ Tokens.<br>
Extension works in files of `ContentType` `"C/C++"`, _eg_ `.cpp` or `.h` files.

## Usage
New entries will appear in `Tools` → `Options` → `Environment` → `Fonts and Colors` → `Text Editor`.<br>
Each will begin with `C++ Token:` prefix.

- Edit their color values, until you want to keep extension default ones (listed below).
- If you don't want to change some token's color at all, set it's `Item foreground` value to `Automatic`.

![](https://raw.githubusercontent.com/Benio101/Color.Token/2022/Color.Token/Preview.png)

## Preview
| Default Tokens without extension | Color Tokens with extension enabled
| --- | ---
| ![](https://raw.githubusercontent.com/Benio101/Color.Token/2022/Color.Token/PreviewDisabled.png) | ![](https://raw.githubusercontent.com/Benio101/Color.Token/2022/Color.Token/PreviewEnabled.png)

## Option
New entry will appear in `Tools` → `Options` → `Color.Token`.

### Color macros (`bool`, default: `false`)
Color macros which text is exact as tokens (_eg_ color `bool` macro defined by `stdbool.h` header in C).

### Note
Note that editing option does not take immediate effect to keep performance.<br>
It requires reclassification, _eg_ triggered by editing corresponding part of code.

## List of Tokens
Extension exposes following Tokens for customization:
- All [keyword](https://en.cppreference.com/w/cpp/keyword)s, except:
  - Keywords that provide an [alternative way to represent standard tokens](https://en.cppreference.com/w/cpp/language/operator_alternative), _eg_ `xor_eq` (trigraphs are removed)
  - `register` keyword (it's unused)
- Identifiers with special meaning, except:
  - Identifiers used as [`contract-level`](http://eel.is/c++draft/gram#nt:contract-level) in [Contract Attributes](https://en.cppreference.com/w/cpp/language/attributes/contract), except `default` (it's also a keyword)

Full list of customizable Tokens, with their default colors:

| Token                              | Type      | Color       | RGB (0 – 255) |
| :---                               | :---      | :---        | :---          |
| `alignas`                          | Keyword   | Blue        | 128, 176, 224 |
| `alignof`                          | Keyword   | Blue        | 128, 176, 224 |
| `asm`                              | Assembler | Purple      | 200, 176, 224 |
| `atomic_cancel`                    | Keyword   | Blue        | 128, 176, 224 |
| `atomic_commit`                    | Keyword   | Blue        | 128, 176, 224 |
| `atomic_noexcept`                  | Keyword   | Blue        | 128, 176, 224 |
| `auto`                             | Type      | Lime        | 176, 224, 128 |
| `bool`                             | Type      | Lime        | 176, 224, 128 |
| `break`                            | Flow      | Violet      | 128, 128, 224 |
| `case`                             | Flow      | Violet      | 128, 128, 224 |
| `catch`                            | Flow      | Violet      | 128, 128, 224 |
| `char`                             | Type      | Lime        | 176, 224, 128 |
| `char8_t`                          | Type      | Lime        | 176, 224, 128 |
| `char16_t`                         | Type      | Lime        | 176, 224, 128 |
| `char32_t`                         | Type      | Lime        | 176, 224, 128 |
| `class`                            | Keyword   | Blue        | 128, 176, 224 |
| `concept`                          | Keyword   | Blue        | 128, 176, 224 |
| `const`                            | Keyword   | Blue        | 128, 176, 224 |
| `consteval`                        | Keyword   | Blue        | 128, 176, 224 |
| `constexpr`                        | Keyword   | Blue        | 128, 176, 224 |
| `constinit`                        | Keyword   | Blue        | 128, 176, 224 |
| `const_cast`                       | Keyword   | Blue        | 128, 176, 224 |
| `continue`                         | Flow      | Violet      | 128, 128, 224 |
| `co_await`                         | Flow      | Violet      | 128, 128, 224 |
| `co_return`                        | Flow      | Violet      | 128, 128, 224 |
| `co_yield`                         | Flow      | Violet      | 128, 128, 224 |
| `decltype`                         | Keyword   | Blue        | 128, 176, 224 |
| `default` (function definition)    | Keyword   | Blue        | 128, 176, 224 |
| `default` (`switch` statement)     | Flow      | Violet      | 128, 128, 224 |
| `delete`                           | Important | Red         | 224, 128, 128 |
| `do`                               | Flow      | Violet      | 128, 128, 224 |
| `double`                           | Type      | Lime        | 176, 224, 128 |
| `dynamic_cast`                     | Keyword   | Blue        | 128, 176, 224 |
| `else`                             | Flow      | Violet      | 128, 128, 224 |
| `enum`                             | Keyword   | Blue        | 128, 176, 224 |
| `explicit`                         | Keyword   | Blue        | 128, 176, 224 |
| `export`                           | Keyword   | Blue        | 128, 176, 224 |
| `extern`                           | Keyword   | Blue        | 128, 176, 224 |
| `false`                            | Static    | Red         | 224, 128, 128 |
| `final`                            | Keyword   | Blue        | 128, 176, 224 |
| `float`                            | Type      | Lime        | 176, 224, 128 |
| `for`                              | Flow      | Violet      | 128, 128, 224 |
| `friend`                           | Keyword   | Blue        | 128, 176, 224 |
| `goto`                             | Flow      | Violet      | 128, 128, 224 |
| `if`                               | Flow      | Violet      | 128, 128, 224 |
| `import`                           | Keyword   | Blue        | 128, 176, 224 |
| `inline`                           | Keyword   | Blue        | 128, 176, 224 |
| `int`                              | Type      | Lime        | 176, 224, 128 |
| `long`                             | Type      | Lime        | 176, 224, 128 |
| `module`                           | Keyword   | Blue        | 128, 176, 224 |
| `mutable`                          | Keyword   | Blue        | 128, 176, 224 |
| `namespace`                        | Keyword   | Blue        | 128, 176, 224 |
| `new`                              | Important | Red         | 224, 128, 128 |
| `noexcept`                         | Keyword   | Blue        | 128, 176, 224 |
| `nullptr`                          | Static    | Red         | 224, 128, 128 |
| `operator`                         | Keyword   | Blue        | 128, 176, 224 |
| `override`                         | Keyword   | Blue        | 128, 176, 224 |
| `private`                          | Access    | Dark Red    | 176, ​ 80, ​ 80 |
| `protected`                        | Access    | Dark Yellow | 176, 176, ​ 80 |
| `public`                           | Access    | Dark Green  | ​ 80, 176, ​ 80 |
| `reflexpr`                         | Keyword   | Blue        | 128, 176, 224 |
| `reinterpret_cast`                 | Keyword   | Blue        | 128, 176, 224 |
| `requires`                         | Keyword   | Blue        | 128, 176, 224 |
| `return`                           | Flow      | Violet      | 128, 128, 224 |
| `short`                            | Type      | Lime        | 176, 224, 128 |
| `signed`                           | Type      | Lime        | 176, 224, 128 |
| `sizeof`                           | Keyword   | Blue        | 128, 176, 224 |
| `static`                           | Keyword   | Blue        | 128, 176, 224 |
| `static_assert`                    | Keyword   | Blue        | 128, 176, 224 |
| `static_cast`                      | Keyword   | Blue        | 128, 176, 224 |
| `struct`                           | Keyword   | Blue        | 128, 176, 224 |
| `switch`                           | Flow      | Violet      | 128, 128, 224 |
| `synchronized`                     | Keyword   | Blue        | 128, 176, 224 |
| `template`                         | Keyword   | Blue        | 128, 176, 224 |
| `this`                             | Keyword   | Blue        | 128, 176, 224 |
| `thread_local`                     | Keyword   | Blue        | 128, 176, 224 |
| `throw`                            | Flow      | Violet      | 128, 128, 224 |
| `transaction_safe`                 | Keyword   | Blue        | 128, 176, 224 |
| `transaction_safe_dynamic`         | Keyword   | Blue        | 128, 176, 224 |
| `true`                             | Static    | Red         | 224, 128, 128 |
| `try`                              | Flow      | Violet      | 128, 128, 224 |
| `typedef`                          | Keyword   | Blue        | 128, 176, 224 |
| `typeid`                           | Keyword   | Blue        | 128, 176, 224 |
| `typename`                         | Keyword   | Blue        | 128, 176, 224 |
| `union`                            | Keyword   | Blue        | 128, 176, 224 |
| `unsigned`                         | Type      | Lime        | 176, 224, 128 |
| `using`                            | Keyword   | Blue        | 128, 176, 224 |
| `virtual`                          | Keyword   | Blue        | 128, 176, 224 |
| `void`                             | Type      | Lime        | 176, 224, 128 |
| `volatile`                         | Keyword   | Blue        | 128, 176, 224 |
| `wchar_t`                          | Type      | Lime        | 176, 224, 128 |
| `while`                            | Flow      | Violet      | 128, 128, 224 |

## Notes
- `asm` can be preceded or followed by up to two underscore characters (U+005F, `_`), _eg_ `__asm`.
- `default` (`switch` statement) means `default` keyword is followed by `:` (possibly after whitespaces).

## Older versions
### 2019
- Branch: [`2019`](https://github.com/Benio101/Color.Token/tree/2019)
- Release: [`1.3.0.2+2019`](https://github.com/Benio101/Color.Token/releases/tag/1.3.0.2%2B2019)
- Download: [`Color.Token.vsix`](https://github.com/Benio101/Color.Token/releases/download/1.3.0.2%2B2019/Color.Token.vsix)
- Marketplace: [`Color.Token (2019)`](https://marketplace.visualstudio.com/items?itemName=Benio.ColorToken2019)

### 2017
- Branch: [`2017`](https://github.com/Benio101/Color.Token/tree/2017)
- Release: [`1.3.1.1+2017`](https://github.com/Benio101/Color.Token/releases/tag/1.3.1.1%2B2017)
- Download: [`Color.Token.vsix`](https://github.com/Benio101/Color.Token/releases/download/1.3.1.1%2B2017/Color.Token.vsix)
- Marketplace: [`Color.Token (2017)`](https://marketplace.visualstudio.com/items?itemName=Benio.ColorToken)
