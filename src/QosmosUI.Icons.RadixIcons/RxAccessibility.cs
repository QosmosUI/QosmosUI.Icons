// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons;

public class RxAccessibility : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "15";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 15 15";

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
		builder.AddAttribute(15, "clip-rule", "evenodd");
		builder.AddAttribute(16, "d", "M0.877197 7.49984C0.877197 3.84216 3.84234 0.877014 7.50003 0.877014C11.1577 0.877014 14.1229 3.84216 14.1229 7.49984C14.1229 11.1575 11.1577 14.1227 7.50003 14.1227C3.84234 14.1227 0.877197 11.1575 0.877197 7.49984ZM7.50003 1.82701C4.36702 1.82701 1.8272 4.36683 1.8272 7.49984C1.8272 10.6328 4.36702 13.1727 7.50003 13.1727C10.633 13.1727 13.1729 10.6328 13.1729 7.49984C13.1729 4.36683 10.633 1.82701 7.50003 1.82701ZM7.12457 9.00001C7.06994 9.12735 6.33165 11.9592 6.33165 11.9592C6.26018 12.226 5.98601 12.3843 5.71928 12.3128C5.45255 12.2413 5.29425 11.9672 5.36573 11.7004C5.36573 11.7004 6.24661 8.87268 6.24661 8.27007V6.80099L4.28763 6.27608C4.0209 6.20461 3.86261 5.93045 3.93408 5.66371C4.00555 5.39698 4.27972 5.23869 4.54645 5.31016C4.54645 5.31016 6.20042 5.87268 6.84579 5.87268H8.15505C8.80042 5.87268 10.4534 5.31042 10.4534 5.31042C10.7202 5.23895 10.9943 5.39724 11.0658 5.66397C11.1373 5.93071 10.979 6.20487 10.7122 6.27635L8.74661 6.80303V8.27007C8.74661 8.87268 9.62663 11.6971 9.62663 11.6971C9.6981 11.9639 9.5398 12.238 9.27307 12.3095C9.00634 12.381 8.73217 12.2227 8.6607 11.956C8.6607 11.956 7.91994 9.12735 7.86866 9.00001C7.81994 8.87268 7.65006 8.87268 7.65006 8.87268H7.34317C7.34317 8.87268 7.16994 8.87268 7.12457 9.00001ZM7.50043 5.12007C8.12175 5.12007 8.62543 4.61639 8.62543 3.99507C8.62543 3.37375 8.12175 2.87007 7.50043 2.87007C6.87911 2.87007 6.37543 3.37375 6.37543 3.99507C6.37543 4.61639 6.87911 5.12007 7.50043 5.12007Z");
		builder.AddAttribute(17, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
