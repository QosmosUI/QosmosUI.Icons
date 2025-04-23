// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.AntDesignIcons.Outline;

public class AiOutlineVerified : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "200";

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
    public string ViewBox { get; set; } = "0 0 1024 1024";

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
		builder.AddAttribute(14, "d", "M447.8 588.8l-7.3-32.5c-0.2-1-0.6-1.9-1.1-2.7-2.5-3.7-7.4-4.7-11.1-2.2L405 567V411c0-4.4-3.6-8-8-8h-81c-4.4 0-8 3.6-8 8v36c0 4.4 3.6 8 8 8h37v192.4c0 1.7 0.5 3.3 1.5 4.7 2.6 3.6 7.6 4.4 11.2 1.8l79-56.8c2.6-1.9 3.8-5.1 3.1-8.3zM391.1 372.2l0.2 0.2c3.2 3 8.3 2.8 11.3-0.5l24.1-26.2c2.9-3.2 2.8-8.1-0.3-11.2l-53.7-52.1c-3.1-3-8.1-3-11.2 0.1l-24.7 24.7c-3.1 3.1-3.1 8.2 0.1 11.3l54.2 53.7z");
		builder.AddAttribute(15, "p-id", "14615");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M866.9 169.9L527.1 54.1C523 52.7 517.5 52 512 52s-11 0.7-15.1 2.1L157.1 169.9c-8.3 2.8-15.1 12.4-15.1 21.2v482.4c0 8.8 5.7 20.4 12.6 25.9L499.3 968c3.5 2.7 8 4.1 12.6 4.1s9.2-1.4 12.6-4.1l344.7-268.6c6.9-5.4 12.6-17 12.6-25.9V191.1c0.2-8.8-6.6-18.3-14.9-21.2zM810 654.3L512 886.5 214 654.3V226.7l298-101.6 298 101.6v427.6z");
		builder.AddAttribute(18, "p-id", "14616");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M452 297v36c0 4.4 3.6 8 8 8h108v274h-38V405c0-4.4-3.6-8-8-8h-35c-4.4 0-8 3.6-8 8v210h-31c-4.4 0-8 3.6-8 8v37c0 4.4 3.6 8 8 8h244c4.4 0 8-3.6 8-8v-37c0-4.4-3.6-8-8-8h-72V493h58c4.4 0 8-3.6 8-8v-35c0-4.4-3.6-8-8-8h-58V341h63c4.4 0 8-3.6 8-8v-36c0-4.4-3.6-8-8-8H460c-4.4 0-8 3.6-8 8z");
		builder.AddAttribute(21, "p-id", "14617");
		builder.CloseElement();
		builder.CloseElement();
    }
}
