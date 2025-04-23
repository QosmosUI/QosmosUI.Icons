// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify;

public class TfiMapAlt : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "17";

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
    public string ViewBox { get; set; } = "0 0 17 17";

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
		builder.OpenElement(13, "g");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M15 4v0.069l-0.013-0.058-1.015 0.221c-0.139-1.803-1.634-3.232-3.472-3.232-1.841 0-3.339 1.435-3.474 3.242l-1.026-0.223v-0.019h-6v11h5.348l5.196 1.479 5.456-1.605v-10.874h-1zM10.5 2c1.379 0 2.5 1.122 2.5 2.5 0 1.806-1.719 4.209-2.5 5.207-0.781-0.998-2.5-3.401-2.5-5.207 0-1.378 1.121-2.5 2.5-2.5zM6 5.042l1.081 0.235c0.412 2.269 2.406 4.788 2.919 5.406v4.602l-4-1.139v-9.104zM1 5h4v9.017l-4-0.017v-9zM11 15.303v-4.621c0.514-0.619 2.513-3.145 2.921-5.416l1.079-0.234v9.094l-4 1.177zM11.858 4.583c0-0.749-0.609-1.358-1.358-1.358s-1.358 0.609-1.358 1.358 0.609 1.359 1.358 1.359 1.358-0.609 1.358-1.359zM10.142 4.583c0-0.198 0.161-0.358 0.358-0.358s0.358 0.161 0.358 0.358-0.161 0.359-0.358 0.359-0.358-0.161-0.358-0.359z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
