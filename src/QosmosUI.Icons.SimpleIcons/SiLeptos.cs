// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiLeptos : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M10.097 17.876A6.207 6.207 0 0 1 5.834 12c0-3.393 2.773-6.166 6.166-6.166.248 0 .517.021.766.042a9.896 9.896 0 0 1 1.49-2.504 3.575 3.575 0 0 1-.85-2.296c0-.331.042-.662.146-.993A19.487 19.487 0 0 0 12 0C5.38 0 0 5.38 0 12c0 4.366 2.338 8.172 5.814 10.283l.124-.062a8.434 8.434 0 0 0 4.159-4.345Zm6.848-14.979c.662 0 1.262-.352 1.593-.952v-.02a12.32 12.32 0 0 0-3.269-1.49v.02a1.851 1.851 0 0 0-.124.642c0 .993.807 1.8 1.8 1.8ZM19.924 3c-.662 1.014-1.758 1.634-2.98 1.634a3.54 3.54 0 0 1-.806-.103 3.153 3.153 0 0 1-.476-.145 8.75 8.75 0 0 0-1.22 1.945c2.275.993 3.724 3.186 3.724 5.669 0 3.393-2.773 6.166-6.166 6.166h-.145a10.374 10.374 0 0 1-4.117 5.048C9.062 23.71 10.51 24 12 24c6.62 0 12-5.38 12-12 0-3.58-1.572-6.807-4.076-9Zm-8.848 4.67a4.428 4.428 0 1 0 1.849 8.661 4.428 4.428 0 1 0-1.85-8.66z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
