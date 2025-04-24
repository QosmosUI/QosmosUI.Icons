// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiGuitarpro : ComponentBase
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
		builder.AddAttribute(15, "d", "M11.998 0C6.422 0 1.773 3.573 1.773 7.295S8.561 23.973 11.998 24c3.435.027 10.218-12.971 10.229-16.705C22.227 3.575 17.575 0 11.998 0zm3.842 5.078a2.292 2.292 0 0 1 2.389 2.34l.007 1.783a2.267 2.267 0 0 1-2.265 2.342 2.364 2.364 0 0 1-1.772-.799v3.115l-1.746.239V5.375l1.688-.287.058.785a2.292 2.292 0 0 1 1.64-.795zm-5.555.035h1.7l-.005 5.953c0 1.736-.931 2.973-2.58 2.973a4.946 4.946 0 0 1-2.423-.523l.207-1.748a3.297 3.297 0 0 0 1.996.843.946.946 0 0 0 1.056-.998v-.904l-.011.014a2.333 2.333 0 0 1-1.77.806 2.28 2.28 0 0 1-2.26-2.345V7.47a2.285 2.285 0 0 1 4.03-1.551zM9.082 6.385a1.156 1.156 0 0 0-1.139 1.273v1.26a1.164 1.164 0 0 0 1.139 1.258 1.183 1.183 0 0 0 1.154-1.139V7.55a1.158 1.158 0 0 0-1.154-1.153zm5.98.008a1.152 1.152 0 0 0-.874 1.228v1.33a1.18 1.18 0 0 0 1.152 1.26 1.166 1.166 0 0 0 1.14-1.26v-1.33a1.152 1.152 0 0 0-1.418-1.228z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
