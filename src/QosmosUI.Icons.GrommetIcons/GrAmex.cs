// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons;

public class GrAmex : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "d", "M4.31351102,11.9651322 L3.49408345,9.96838176 L2.67933919,11.9651322 L4.31351102,11.9651322 Z M12.1730058,14.1264026 L12.1684736,10.2036046 L10.4324776,14.1264026 L9.38130189,14.1264026 L7.64077369,10.2001299 L7.64077369,14.1264026 L5.20575645,14.1264026 L4.74573489,13.0092074 L2.25300723,13.0092074 L1.78830236,14.1264026 L0.488004966,14.1264026 L2.63190183,9.11768179 L4.41065186,9.11768179 L6.44683267,13.8599073 L6.44683267,9.11768179 L8.40082901,9.11768179 L9.96762165,12.5154962 L11.4069075,9.11768179 L13.4001832,9.11768179 L13.4001832,14.1264026 L12.1730058,14.1264026 Z M15.3055732,13.1015049 L15.3055732,12.104716 L17.9339657,12.104716 L17.9339657,11.0825466 L15.3055732,11.0825466 L15.3055732,10.171719 L18.3071194,10.171719 L19.6166324,11.6317021 L18.2491069,13.1015049 L15.3055732,13.1015049 Z M23.4171068,14.1455801 L21.8614469,14.1455801 L20.3872629,12.4870853 L18.8552174,14.1455801 L14.1129918,14.1455801 L14.1129918,9.13565077 L18.9281863,9.13565077 L20.4011617,10.7778295 L21.9239917,9.13565077 L23.488005,9.13565077 L21.1613628,11.6406155 L23.4171068,14.1455801 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
