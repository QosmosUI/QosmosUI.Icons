// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons.Default;

public class DiDatabase : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "32";

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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M16 27.534c-5.323 0-9.641-1.44-9.641-3.214 0-0.97 0-2.031 0-3.214 0-0.279 0.14-0.545 0.341-0.803 1.075 1.384 4.813 2.41 9.301 2.41s8.226-1.026 9.301-2.41c0.201 0.259 0.34 0.524 0.34 0.803 0 0.931 0 1.918 0 3.214 0 1.773-4.318 3.214-9.641 3.214zM16 21.106c-5.323 0-9.641-1.441-9.641-3.214 0-0.97 0-2.030 0-3.214 0-0.17 0.064-0.336 0.151-0.5v0c0.049-0.103 0.113-0.204 0.19-0.304 1.075 1.383 4.813 2.41 9.301 2.41s8.226-1.027 9.301-2.41c0.077 0.1 0.141 0.201 0.19 0.304v0c0.086 0.164 0.151 0.33 0.151 0.5 0 0.931 0 1.917 0 3.214 0 1.773-4.318 3.214-9.641 3.214zM16 14.679c-5.323 0-9.641-1.44-9.641-3.214 0-0.508 0-1.044 0-1.607 0-0.511 0-1.041 0-1.607 0-1.774 4.318-3.214 9.641-3.214s9.641 1.44 9.641 3.214c0 0.501 0 1.033 0 1.607 0 0.492 0 1.011 0 1.607 0 1.774-4.318 3.214-9.641 3.214zM16 6.645c-3.55 0-6.427 0.718-6.427 1.607s2.878 1.607 6.427 1.607c3.55 0 6.427-0.718 6.427-1.607s-2.878-1.607-6.427-1.607z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
