// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiFanfou : ComponentBase
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
		builder.AddAttribute(15, "d", "m21.96.0655 1.369 2.082c-3.2662.9041-6.8623 1.5142-10.7875 1.8302v3.8061H22.736c-.448 4.4272-1.616 7.9444-3.5041 10.5525 1.239 1.475 2.8271 2.788 4.7682 3.9381l-1.7 1.6601a25.133 25.133 0 0 1-4.5823-3.7402 20.9459 20.9459 0 0 1-4.9932 3.7402l-1.528-1.726c2.143-1.2121 3.8151-2.4762 5.0192-3.7932-1.599-2.5201-2.6441-5.2913-3.1352-8.3124h-.54c.07 5.5593-.892 10.1604-2.8851 13.8056l-2.002-1.396c1.73-3.0302 2.594-7.2944 2.594-12.7916V1.8966c4.2872-.167 8.1904-.776 11.7125-1.8301Zm-1.8972 10.0384h-4.6102c.35 2.3001 1.115 4.4132 2.2921 6.3353 1.184-1.861 1.9571-3.9732 2.3181-6.3353zM9.4054 3.6227c-.123 1.984-.51 4.0441-1.159 6.1772l-2.1461-.618c.308-.887.584-1.9551.83-3.2002H3.583C2.96 7.4998 2.314 8.8299 1.646 9.9709L0 8.18C1.186 6.0817 2.138 3.3845 2.8581.0924l2.2401.646a63.5656 63.5656 0 0 1-.764 2.8842Zm-.961 15.7546c-1.6161 1.616-3.1532 2.9021-4.6102 3.8602L2.45 21.3274c.255-.22.382-.554.382-1.002V8.4308h2.3451v10.8404c.623-.483 1.396-1.185 2.3181-2.107z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
