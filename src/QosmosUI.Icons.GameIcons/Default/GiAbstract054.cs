// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiAbstract054 : ComponentBase
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
		builder.AddAttribute(14, "d", "m250.7622,20.9999c-95.0948,0-171.6585,97.1409-171.6585,217.6685v193.1409h-27.6548v-341.0664c8.501-3.3755 14.5257-11.9149 14.5257-22.0312 0-13.0533-10.0742-23.6467-22.4876-23.6467s-22.487,10.5934-22.487,23.6467c0,10.2794 6.3671,18.9217 15.0843,22.1784v400.11h1.5364 13.8282 27.6548 353.9316 27.6556 13.8275 1.5364v-400.11c8.7172-3.2567 14.9452-11.899 14.9452-22.1784 0-13.0533-10.0742-23.6467-22.4877-23.6467s-22.4869,10.5934-22.4869,23.6467c0,10.1163 6.1645,18.6557 14.6655,22.0312v341.0664h-27.6556v-193.1409c0-120.5276-76.5636-217.6685-171.6584-217.6685zm.8381,39.0688h8.9392c79.2639,0 143.0249,80.9257 143.0249,181.3905v190.35h-294.9897v-190.35c0-100.4648 63.7617-181.3905 143.0256-181.3905zm.8382,32.8999c-65.9871,0-119.1414,67.3529-119.1414,150.9873v158.9192h245.5448v-158.9192c0-83.6344-53.1542-150.9873-119.1406-150.9873zm3.6314,65.2125c47.7701,0 86.5967,43.8258 86.5967,97.819s-38.8266,97.8182-86.5967,97.8182-86.5975-43.826-86.5975-97.8182 38.8267-97.819 86.5975-97.819zm0,33.3406c-31.4974,0-56.9867,28.8786-56.9867,64.4783s25.4893,64.4779 56.9867,64.4779 56.986-28.8792 56.986-64.4779-25.4893-64.4783-56.986-64.4783zm0,37.6c13.1233,0 23.7438,12.0451 23.7438,26.8783s-10.6205,26.8779-23.7438,26.8779-23.7445-12.0462-23.7445-26.8779 10.6204-26.8783 23.7445-26.8783zm-204.621,240.2875h409.242v9.6938h-409.242z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
