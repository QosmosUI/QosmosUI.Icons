// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiOreilly : ComponentBase
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
		builder.AddAttribute(15, "d", "M12.07 10.679v-.672H9.32v3.97h2.751v-.656H9.975v-1h2.002v-.657H9.975v-.985zm2.049 3.299v-3.971h.656v3.314h1.908v.657zm3.111 0v-3.971h.657v3.314h1.907v.657zm-4.456-3.971h.657v3.97h-.657zM1.079 11.023c-.25.25-.407.594-.407.985 0 .39.157.735.407 1a1.418 1.418 0 0 0 1.986 0c.25-.265.406-.61.406-1 0-.391-.156-.735-.407-.985a1.418 1.418 0 0 0-1.985 0M0 12.008c0-1.142.922-2.064 2.064-2.064 1.141 0 2.064.922 2.064 2.064a2.062 2.062 0 0 1-2.064 2.064A2.062 2.062 0 0 1 0 12.008Zm6.176-.344v-.985h1.329a.5.5 0 0 1 .5.485c0 .281-.234.5-.5.5zm1.657.61c.485-.141.829-.579.829-1.11 0-.642-.516-1.157-1.157-1.157H5.519v3.97h.657v-1.656h.922l.985 1.657h.782zM5.05 10.429a.477.477 0 0 1-.485.484.468.468 0 0 1-.484-.484c0-.266.203-.485.484-.485.266 0 .485.219.485.485zm17.684-.422h-.798l-1.016 1.47-1.016-1.47h-.813l1.485 2.157v1.814h.672v-1.814zm.781.813a.404.404 0 0 1-.406-.407c0-.219.172-.406.406-.406.22 0 .407.187.407.406a.414.414 0 0 1-.407.407m0-.892a.487.487 0 0 0-.484.485c0 .266.219.485.484.485a.487.487 0 0 0 .485-.485.487.487 0 0 0-.485-.485zm-.125.313h.203c.032 0 .063.031.063.063a.067.067 0 0 1-.063.062h-.203zm.344.063a.14.14 0 0 0-.14-.141h-.282v.5h.078v-.219h.14l.11.22h.094l-.11-.22a.15.15 0 0 0 .11-.14");
		builder.CloseElement();
		builder.CloseElement();
    }
}
