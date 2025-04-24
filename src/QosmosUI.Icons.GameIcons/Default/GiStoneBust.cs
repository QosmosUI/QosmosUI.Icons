// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiStoneBust : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 25c14.33 0 27.676 7.905 37.977 22.068C304.277 61.232 311 81.468 311 104c0 22.532-6.723 42.768-17.023 56.932C283.676 175.095 270.329 183 256 183c-14.33 0-27.676-7.905-37.977-22.068C207.723 146.768 201 126.532 201 104c0-22.532 6.722-42.768 17.023-56.932C228.324 32.905 241.671 25 256 25zm40 78h-80v18h31v23h18v-23h31zm4.777 77.732c22.269 3.505 48.815 9.312 84.93 17.334-18.385 31.94-30.507 71.784-36.947 105.024-30.784 3.249-71.261 9.48-92.76-11.819-23.106 21.245-68.115 17.842-92.838 11.424-6.459-33.161-18.556-72.814-36.869-104.629 36.115-8.022 62.661-13.829 84.93-17.334C223.35 193.18 238.89 201 256 201c17.11 0 32.65-7.82 44.777-20.268zM265 224h-18v48h18zm-8.992 91.117c25.254 11.781 65.5 11.202 89.556 7.113-1.059 7.611-1.768 14.623-2.12 20.77H168.556c-.358-6.232-1.08-13.351-2.164-21.084 29 2.217 65.796 6.81 89.615-6.799zM315 361v94h-18v-64h-82v64h-18v-94zm-36 48v46h-46v-46zm69.271 64l14 18H149.73l14-18z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
