// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiAbstract030 : ComponentBase
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
		builder.AddAttribute(14, "d", "m210.287,20.9997c-95.5558,18.4904-170.817,93.7559-189.287,189.3473h163.1009c25.3227,0 45.638,20.1723 45.638,45.5032s-20.3153,45.8027-45.638,45.8027h-163.1009c18.4701,95.5914 93.7312,170.8569 189.287,189.3473v-163.1531c0-25.3307 20.3153-45.6529 45.6384-45.6529s45.7875,20.3222 45.7875,45.6529v163.1531c95.5553-18.4904 170.8174-93.7559 189.2871-189.3473h-162.9511c-25.3227,0-45.7879-20.4717-45.7879-45.8027s20.4652-45.5032 45.7879-45.5032h162.9511c-18.4696-95.5914-93.7312-170.8569-189.2866-189.3473v162.8537c0,25.3307-20.4652,45.8026-45.7879,45.8026s-45.6384-20.4719-45.6384-45.8026v-162.8537z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
