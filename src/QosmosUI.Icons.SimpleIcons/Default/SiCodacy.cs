// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiCodacy : ComponentBase
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
		builder.AddAttribute(15, "d", "M3.883 9.825a8.46 8.46 0 0 1 3.875-5.07l.04-.021-1.803-3.113C3.276 3.212 1.268 5.769.427 8.81l-.02.084zM9.824 3.894a8.246 8.246 0 0 1 2.164-.283h.005V.016h-.019a12.05 12.05 0 0 0-3.165.421l.084-.02zM14.178 3.897a8.449 8.449 0 0 1 5.063 3.875l.021.04 3.117-1.799c-1.591-2.718-4.146-4.726-7.186-5.568l-.084-.02zM0 12v.006c0 1.1.148 2.165.425 3.177l-.02-.084 3.476-.929a8.14 8.14 0 0 1-.284-2.161v-.008zM1.605 17.995c.55.941 1.18 1.754 1.901 2.475l2.553-2.54a8.56 8.56 0 0 1-1.313-1.695l-.022-.04zM5.995 22.38a11.77 11.77 0 0 0 5.967 1.604h.021-.001v-3.595h-.004a8.308 8.308 0 0 1-4.223-1.145l.039.021zM19.259 16.205a8.44 8.44 0 0 1-5.034 3.884l-.059.014.931 3.476c3.124-.86 5.681-2.863 7.246-5.52l.031-.056zM23.577 15.221c.268-.947.423-2.035.423-3.159 0-1.087-.144-2.14-.415-3.142l.019.084-3.486.931c.175.64.275 1.374.275 2.132 0 .79-.109 1.555-.313 2.28l.014-.059z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
