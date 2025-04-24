// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiGnusocial : ComponentBase
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
		builder.AddAttribute(15, "d", "M4.217 0C2.474 0 1.06 1.413 1.06 3.156V15.77c0 1.744 1.414 3.158 3.157 3.158h9.367C13.567 22.498 8.756 24 8.756 24s8.138-.038 9.305-5.072h1.72c1.744 0 3.157-1.414 3.157-3.157V3.157C22.938 1.413 21.524 0 19.782 0H4.218zm4.527 2.53c.073-.013.132-.003.174.034.335.3-.556.593-.484 2.063.032.646-.16 1.146 1.076 1.146.826 0 .483-.734 1.523-.734.656 0 .86.435.934.767.072-.33.274-.768.93-.768 1.04 0 .7.733 1.525.733 1.237 0 1.044-.5 1.076-1.146.072-1.47-.82-1.764-.484-2.063.042-.037.1-.042.172-.02.5.143 1.607 1.558 1.638 2.155.038.71.04 1.825-1.015 2.407 1.19 1.167 1.352 2.72 1.352 2.72l-2.045-.034s-.464-2.118-2.94-2.01c-2.474.108-2.796.538-2.796 3.156 0 2.617 1.147 3.517 2.905 3.585 2.76.108 2.51-1.433 2.51-1.433l-1.29.072-.718-1.937h4.41c0 2.116-.897 5.414-5.092 5.2-4.196-.216-5.128-3.515-5.164-5.74-.018-1.225.188-2.602 1.2-3.574-1.052-.58-1.033-1.7-1.033-2.414 0-.88 1.13-2.084 1.637-2.17z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
