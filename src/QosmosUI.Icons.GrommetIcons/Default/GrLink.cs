// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons.Default;

public class GrLink : ComponentBase
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
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "stroke-width", "2");
		builder.AddAttribute(16, "d", "M16.1251884,2.42026615 C16.9095797,1.63587482 18.1818354,1.63638083 18.9643331,2.41887857 L21.5811214,5.03566688 C22.3647464,5.81929188 22.3723943,7.08215115 21.5797338,7.87481161 L17.8748116,11.5797338 C17.0904203,12.3641252 15.8181646,12.3636192 15.0356669,11.5811214 L12.4188786,8.96433312 C11.6352536,8.18070812 11.6276057,6.91784885 12.4202662,6.12518839 L16.1251884,2.42026615 Z M6.12518839,12.4202662 C6.90957973,11.6358748 8.18183538,11.6363808 8.96433312,12.4188786 L11.5811214,15.0356669 C12.3647464,15.8192919 12.3723943,17.0821512 11.5797338,17.8748116 L7.87481161,21.5797338 C7.09042027,22.3641252 5.81816462,22.3636192 5.03566688,21.5811214 L2.41887857,18.9643331 C1.63525357,18.1807081 1.6276057,16.9178488 2.42026615,16.1251884 L6.12518839,12.4202662 Z M7,17 L17,7");
		builder.CloseElement();
		builder.CloseElement();
    }
}
