// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiPencilRuler2Line : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M7.05033 14.1213L4.929 16.2427L7.75743 19.0711L19.0711 7.75737L16.2427 4.92894L14.1214 7.05026L15.5356 8.46448L14.1214 9.87869L12.7072 8.46448L11.293 9.87869L12.7072 11.2929L11.293 12.7071L9.87875 11.2929L8.46454 12.7071L9.87875 14.1213L8.46454 15.5355L7.05033 14.1213ZM16.9498 2.80762L21.1925 7.05026C21.583 7.44079 21.583 8.07395 21.1925 8.46448L8.46454 21.1924C8.07401 21.5829 7.44085 21.5829 7.05033 21.1924L2.80768 16.9498C2.41716 16.5592 2.41716 15.9261 2.80768 15.5355L15.5356 2.80762C15.9261 2.4171 16.5593 2.4171 16.9498 2.80762ZM14.1214 18.3635L15.5356 16.9493L17.7781 19.1918H19.1923V17.7776L16.9498 15.5351L18.364 14.1208L20.9997 16.7565V20.9999H16.7578L14.1214 18.3635ZM5.63597 9.87806L2.80754 7.04963C2.41702 6.65911 2.41702 6.02594 2.80754 5.63542L5.63597 2.80699C6.02649 2.41647 6.65966 2.41647 7.05018 2.80699L9.87861 5.63542L8.4644 7.04963L6.34308 4.92831L4.92886 6.34253L7.05018 8.46385L5.63597 9.87806Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
