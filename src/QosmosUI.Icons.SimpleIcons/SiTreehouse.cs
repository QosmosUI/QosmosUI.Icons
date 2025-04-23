// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiTreehouse : ComponentBase
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
		builder.AddAttribute(15, "d", "M20.3981 4.3857c-.8211-.448-2.0902.2986-2.8367 1.6423l-1.4183 2.3888c-.5226.9704-.448 2.1648.224 3.1353l.0746.0747c.6718.8958 1.493 1.7916 1.7916 2.0902.1493.1493.2986.3732.3732.6718.224.8212-.224 1.717-1.1197 1.941-.8212.2239-1.717-.224-1.941-1.1198-.0746-.224-.0746-.448-.0746-.5972.0747-.3733-.0746-.8958-.5972-1.493-.5225-.5226-1.493.5225-1.8662 1.5676v.0747c-.2986 1.045-.5226 2.0155-.448 2.0902 0 .0746.0747.0746.0747.1493.448.8958.1493 1.9409-.7465 2.3888-.8958.4479-1.9409.1493-2.3888-.7465-.4479-.8958-.1493-1.941.7465-2.3888.0747 0 .0747-.0747.1493-.0747.0747 0 .224-.4479.448-1.0451.1492-.5225.2239-.7465.2985-.9704.0747-.2986.224-1.0451.1493-1.3437-.0746-.3733-.4479-.3733-.8211-.1493-.224.1493-.6719.5225-.8212.6718-.3732.2986-.6718.7465-.8211 1.1198-.0747.1493-.224.3732-.3733.5225-.6718.5226-1.6423.4479-2.2395-.224-.5225-.6718-.4479-1.6422.224-2.2394.224-.1494.4479-.2987.6718-.2987.3733-.0746 1.717-.8958 2.5381-1.493.1493-.0746.3733-.2986.448-.3732.2239-.2986 0-.5226-.224-.5226-.6719.0747-1.4184.1493-1.5677.3733-.0746.0746-.1493.224-.2986.2986-.5972.4479-1.493.2986-1.9409-.2986-.4479-.5972-.2986-1.493.2986-1.9409.224-.224.5972-.2986.8212-.2986.5225 0 1.8662.2986 2.9113.0746l.2986-.0746c1.1198-.224 2.4635-1.1944 2.986-2.1649 0 0 .5226-.8958 1.1198-2.0155.6718-1.1198.5972-2.3888-.0747-2.762l-1.269-.7466c-.6719-.3732-1.6423-.3732-2.3142 0L2.1835 5.207C1.5117 5.58.9891 6.4758.9891 7.2223v9.5552c0 .7465.5226 1.6423 1.1944 2.0156L10.843 23.72c.6719.3732 1.717.3732 2.3142 0l8.6594-4.927c.6718-.3732 1.1944-1.269 1.1944-2.0155V7.2224c0-.7465-.5226-1.6423-1.1944-2.0156 0 0-.5972-.3732-1.4184-.8211z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
