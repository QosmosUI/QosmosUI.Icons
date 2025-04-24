// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiGalleon : ComponentBase
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
		builder.AddAttribute(14, "d", "M222.03 20.53v58.25L165.938 99l6.344 17.563 49.75-17.938v96.156l-87.155 33.845 6.75 17.406 80.406-31.218v141.97h-61.655l-1.438-7.594-4.687-25.063H95.812v-142.47l60.157-21.686-6.345-17.595-53.813 19.406V78.345H77.126v90.187l-52 18.75 6.344 17.564 45.655-16.47v135.75H26.437c5.565 54.4 27.327 108.08 66.782 143.595H375.56c9.543-51.545 39.83-95.146 73.688-136.44h-.063L494.594 299l-10.813-15.25-66.874 47.53H367.25V219.314l62.188-22.438-6.313-17.563-55.875 20.157v-67.032h-18.688v73.78l-49.937 18 6.313 17.563 43.625-15.75v121.595l-4.907 5.844-2.812 3.31H240.72V207.564l87.155-33.844-6.78-17.407-80.376 31.218V91.907l56.06-20.22-6.342-17.592-49.72 17.937v-51.5h-18.687z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
