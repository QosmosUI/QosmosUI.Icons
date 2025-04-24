// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiFlatbed : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M97.597 296.31l-60.152-6.047v-23.826h81.745a54.402 54.402 0 0 0-21.593 29.872zM491 311.183a36.866 36.866 0 1 1-36.876-36.866A36.866 36.866 0 0 1 491 311.184zm-6.433 0a30.443 30.443 0 1 0-30.443 30.443 30.474 30.474 0 0 0 30.453-30.443zm-30.433-13.142a13.1 13.1 0 1 0 13.1 13.101 13.1 13.1 0 0 0-13.1-13.1zm-267.543 13.142a36.866 36.866 0 1 1-36.876-36.866 36.866 36.866 0 0 1 36.876 36.866zm-36.876-30.473a30.443 30.443 0 1 0 30.443 30.442 30.474 30.474 0 0 0-30.443-30.442zm0 17.331a13.1 13.1 0 1 0 13.1 13.101 13.1 13.1 0 0 0-13.1-13.1zm118.713-103.767H21v55.85h247.428v-55.85zm219.626 64.393v10.287a54.167 54.167 0 0 0-88.138 42.24H282.1a25.57 25.57 0 0 0-22.256-13.153h-57.522a54.371 54.371 0 0 0-22.113-31.605h104.705v-93.572a12.51 12.51 0 0 1 12.51-12.51h67.604a12.51 12.51 0 0 1 12.51 12.51v2.723h-7.922v44.695h80.093a38.385 38.385 0 0 1 38.345 38.375zm-125.748-83.08H309.29V228h53.016v-52.413z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
